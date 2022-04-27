using System.Collections.Generic;

namespace AlgorithmsTest
{
    public class HeapSort
    {
        public void Sort(List<int> data)
        {
            for (int i = data.Count / 2; i > 0; i--)
            {
                MakeBigHeap(data, i, data.Count);
            }

            for (int i = data.Count; i > 1; i--)
            {
                Swap(data, 1, i);
                MakeBigHeap(data, 1, i - 1);
            }
        }

        public void MakeBigHeap(List<int> data, int start, int length)
        {
            int startIndex = start - 1;
            int big = data[startIndex];
            for (int i = start * 2; i <= length; i *= 2)
            {
                int index = i - 1;
                if (i<length&&data[index] < data[index + 1])//i<length 注意 不然代表没有右节点 不能++
                {
                    index++;
                }

                if (data[index] > big)
                {
                    data[startIndex] = data[index];
                    startIndex = index;
                }
            }

            data[startIndex] = big;
        }

        public void Swap(List<int> data, int s, int t)
        {
            int sIndex = s - 1;
            int tIndex = t - 1;

            int temp = data[sIndex];
            data[sIndex] = data[tIndex];
            data[tIndex] = temp;
        }
    }
}