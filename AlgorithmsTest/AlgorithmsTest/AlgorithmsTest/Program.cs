using System;
using System.Collections.Generic;

namespace AlgorithmsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> data = new List<int>
            {
                1, 2, 3, 4, 5
            };
            // int sum = Sum(data);
            // Console.WriteLine("sum:"+sum);

            HeapSort sort = new HeapSort();
            sort.Sort(data);

            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }

        public static int Sum(List<int> list)
        {
            if (list.Count == 0)
                return 0;
            if (list.Count == 1)
            {
                return list[0];
            }

            int first = list[0];
            list.RemoveAt(0);
            int total = first + Sum(list);
            return total;
        }
    }
}
