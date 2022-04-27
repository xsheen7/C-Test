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
            Son1 son1 = new Son1();
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
