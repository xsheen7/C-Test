using System;
using System.Collections;
using System.Collections.Generic;

namespace ForeachTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList list = new MyList(1,2,3);
            foreach (var VARIABLE in list)
            {
                foreach (var i in list)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public class MyList:IEnumerable
        {
            public int[] array = new int[10];

            public MyList(int a, int b, int c)
            {
                array[0] = a;
                array[1] = b;
                array[2] = c;
            }

            public IEnumerator GetEnumerator()
            {
                return new MyEnumerator(array);
            }
        }

        public class MyEnumerator:IEnumerator
        {
            public int[] list;
            public int index = -1;

            public MyEnumerator(int[] list)
            {
                this.list = list;
                Console.WriteLine("enumerator construct");
            }

            public bool MoveNext()
            {
                index++;
                return index < list.Length;
            }

            public void Reset()
            {
                index = -1;
            }

            public object Current
            {
                get
                {
                    return list[index];
                }
            }
        }
    }
}
