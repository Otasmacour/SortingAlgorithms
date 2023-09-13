using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSort
    {
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = i;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);

                    }
                }
            }
            return array;
        }
        static void Swap(int[] array, int index1, int index2)
        {
            int item1 = array[index1];
            int item2 = array[index2];
            array[index1] = item2;
            array[index2] = item1;
        }
    }
}