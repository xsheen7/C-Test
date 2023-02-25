using System;
using System.Collections.Generic;

namespace AlgorithmsTest
{
    public class QuickSort
    {
        public static int count = 0;

        public static void Test()
        {
            QuickSort sort = new QuickSort();
            List<int> test = new List<int>()
            {
                1, 2, 3, 56, 34, 678, 22, 100
            };
            sort.DoQuickSort(test,0,test.Count-1);

            Console.WriteLine("calc count:"+count);

            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }
        }

         void DoQuickSort(List<int> data,int left,int right)
        {
            if (left < right)
            {
                int index = Partion(data, left, right);
                DoQuickSort(data,left,index-1);
                DoQuickSort(data,index+1,right);
            }
        }

        //一轮排序确定一个位置，将比自己小的依次交换到左边，左边的一定比自己小，右边的一定比自己大，再对左右区域递归
         int Partion(List<int> data, int left, int right)
        {
            int pivot = data[left];
            int index = left + 1;

            for (int i = index; i <= right; i++)
            {
                count++;
                if (data[i] < pivot)
                {
                    Swap(data,i,index);
                    index++;
                }
            }

            Swap(data,left,index-1);
            return index - 1;
        }
         
          void Swap(List<int> data, int a, int b)
         {
             int temp = data[a];
             data[a] = data[b];
             data[b] = temp;
         }
    }
}