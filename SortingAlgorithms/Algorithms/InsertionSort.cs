using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class InsertionSort
    {
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i + 1;
                int tmp = array[j];
                while (j > 0 && tmp < array[j-1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = tmp;

            }
            return array;
        }
    }
}