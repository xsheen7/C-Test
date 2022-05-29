using System;
using System.Collections.Generic;

namespace AlgorithmsTest
{
    public static class ArrayReserve
    {
        /// <summary>
        /// 使用 Array.Reverse(Arrar) 反转全部
        /// </summary>
        /// <param name="arr"></param>
        public static void ReverseDemo1(int[] arr)
        {
            Console.WriteLine("使用 Array.Reverse(Arrar) 反转全部");
            Array.Reverse(arr);
        }

        /// <summary>
        /// 使用 Array.Reverse(Array arr,int begin,int end),反转指定部分
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        public static void ReverseDemo2(int[] arr, int begin, int end)
        {
            Console.WriteLine("使用 Array.Reverse(Array arr,int begin,int end),反转指定部分");
            Array.Reverse(arr, begin, end);
        }

        /// <summary>
        /// 使用自定义方法实现反转
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        public static void ReverseDemo3(int[] arr, int begin, int end)
        {
            Console.WriteLine("使用自定义方法实现反转");
            if (null == arr)
            {
                throw new ArgumentNullException("arr", "Array不能为null");
            }

            if (begin <= 0 || end <= 0)
            {
                throw new ArgumentOutOfRangeException("开始或结束索引没有正确设置");
            }

            if (end > arr.Length)
            {
                throw new ArgumentOutOfRangeException("end", "结束索引超出数组长度");
            }

            while (begin < end)
            {
                int temp = arr[end];
                arr[end] = arr[begin];
                arr[begin] = temp;
                begin++;
                end--;
            }
        }

        /// <summary>
        /// 使用自定义方法实现反转(使用栈《后进先出》）
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        public static void ReverseDemo4(int[] arr, int begin, int end)
        {
            Console.WriteLine("使用自定义方法实现反转(使用栈《后进先出》）");
            if (null == arr)
            {
                throw new ArgumentNullException("arr", "Array不能为null");
            }

            if (begin <= 0 || end <= 0)
            {
                throw new ArgumentOutOfRangeException("开始或结束索引没有正确设置");
            }

            if (end > arr.Length)
            {
                throw new ArgumentOutOfRangeException("end", "结束索引超出数组长度");
            }

            Stack<int> intStack = new Stack<int>();
            int tempBegin = begin;
            for (; begin <= end; begin++)
            {
                intStack.Push(arr[begin]);
            }

            for (; tempBegin <= end; tempBegin++)
            {
                arr[tempBegin] = intStack.Pop();
            }
        }
    }
}