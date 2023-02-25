using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    class Program
    {

        static void Main(string[] args)
        {
            TestEvent testEvent = new TestEvent();
            testEvent.Test();
        }
    }

    public class TestEvent
    {
        public event Action myEvent;
        //public Action myEvent;

        public void Test()
        {
            myEvent += () =>
            {
                Console.WriteLine("call 1");
            };
            myEvent += () =>
            {
                Console.WriteLine("call 2");
            };
            myEvent.Invoke();
            myEvent = () => { };
            myEvent.Invoke();
        }
    }

    public abstract class Base<T>
    {
        public abstract T Get();
    }

    public class Son1 : Base<int>
    {
        public override int Get()
        {
            return 0;
        }
    }
}
