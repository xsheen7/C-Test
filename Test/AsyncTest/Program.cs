using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<int> test = new List<int>();
            int index = 0;
            while (test.Count < 10000)
            {
                bool faile = (index == 3) || (index / 10 == 3) || (index / 100 == 3) || (index / 1000 == 3) || (index / 10000 == 3) || index == 4 || (index % 10 == 4) || (index / 100 == 4) || (index / 1000 == 4) || (index / 10000 == 4) || index == 7 || (index % 10 == 7) || (index / 100 == 7) || (index / 1000 == 7) || (index / 10000 == 7);
                if (faile)
                {
                    index++;
                }
                else
                {
                    test.Add(index);
                    index++;
                }
            }

            Console.WriteLine(test[10000 - 1]);
            Console.ReadLine();

        }

        static async Task<string> GetResult()
        {
            var client = new WebClient();

            var content = await client.DownloadStringTaskAsync(new Uri("http://cnblogs.com"));

            return content;
        }
    }
}
