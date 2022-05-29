using System;
using System.Collections.Generic;

namespace AlgorithmsTest
{
    public class ArraySum
    {
        public static void Test()
        {
            //数组递归求和
            List<int> data = new List<int>
            {
                1, 2, 3, 4, 5
            };
            int sum = Sum(data);
            Console.WriteLine("sum:"+sum);
        }
        
        //递归数组求和
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