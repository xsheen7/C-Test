using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var t in GetEnumerableTest())
            {
                Console.WriteLine(t);
            }


            //string s=GetEnumeratorTest();
        }

        static IEnumerable<string> GetEnumerableTest()
        {
            yield return "ienumerable begin";
            for (int i = 0; i < 10; i++)
            {
                yield return i.ToString();
            }

            yield return "end";
        }

        static IEnumerator<string> GetEnumeratorTest()
        {
            yield return "ienumerator begin";
            for (int i = 0; i < 10; i++)
            {
                yield return i.ToString();
            }

            yield return "end";
        }
    }
}
