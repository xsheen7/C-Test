using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
            };
            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);
        }
    }
}

public class Person
{
    public Person(string fName, string lName)
    {
        this.firstName = fName;
        this.lastName = lName;
    }
    public string firstName;
    public string lastName;
}
public class People : IEnumerable
{
    private Person[] _people;
    public People(Person[] pArray)
    {
        _people = new Person[pArray.Length];
        for (int i = 0; i < pArray.Length; i++)
        {
            _people[i] = pArray[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        Console.WriteLine("get i enumerator");
        return (IEnumerator)GetEnumerator();
    }
    public PeopleEnum GetEnumerator()
    {
        Console.WriteLine("get enumerator");
        return new PeopleEnum(_people);
    }
}
public class PeopleEnum : IEnumerator
{
    public Person[] _people;
    // Enumerators are positioned before the first element
    // until the first MoveNext() call.
    int position = -1;
    public PeopleEnum(Person[] list)
    {
        Console.WriteLine("new enumerator");
        _people = list;
    }
    public bool MoveNext()
    {
        Console.WriteLine("move");
        position++;
        return (position < _people.Length);
    }
    public void Reset()
    {
        position = -1;
    }

    public void Dispose()
    {
        
    }

    object IEnumerator.Current
    {
        get
        {
            Console.WriteLine("get i current");
            return Current;
        }
    }
    public Person Current
    {
        get
        {
            try
            {
                Console.WriteLine("get current");
                return _people[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
