using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneAdapter pa=new NokiaAdapter();
            pa.Start();
        }
    }

    interface PhoneAdapter
    {
        void Start();
        void Close();
    }

    interface Phone
    {
        void Start();
        void Close();
    }

    //已经继承自手机的基类，想要对start方法进行修改，只能创建适配的类
    public class Nokia:Phone
    {
        public void Start()
        {
            Console.WriteLine("hello nokia");
        }

        public void Close()
        {

        }
    }

    public class NokiaAdapter : PhoneAdapter
    {
        private Nokia nokia;


        public NokiaAdapter()
        {
            nokia = new Nokia();
        }
        
        public void Start()
        {
            nokia.Start();
        }

        public void Close()
        {
            nokia.Close();
        }

    }
}
