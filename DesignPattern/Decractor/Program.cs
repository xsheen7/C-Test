using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Borrowable b1=new Borrowable(new Cartoon());
            b1.DoBorrow();

        }
    }

    class Book
    {
        public virtual void Read()
        {

        }
    }

    class Cartoon:Book
    {
        public override void Read()
        {
            base.Read();
            Console.WriteLine("read cartoon");
        }
    }

    class Borrowable:Book
    {
        private Book b;
        public Borrowable(Book b)
        {
            this.b = b;
        }

        public virtual void DoBorrow()
        {
            Console.WriteLine("borrow "+b.GetType().ToString());
        }
    }


    interface IPizza
    {
        string GetDescription();
        double GetCost();
    }

    public class PlainPizza : IPizza
    {
        public double GetCost()
        {
            return 4.00;
        }

        public string GetDescription()
        {
            return "thin dough";
        }
    }

    public class TopDecrector : IPizza
    {

        public double GetCost()
        {
            return base.
        }

        public string GetDescription()
        {
            
        }
    }
}
