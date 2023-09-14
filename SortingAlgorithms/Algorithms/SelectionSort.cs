using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SelectionSort
    {
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = IndexOfSmallestNumber(array, i);
                int tmp = array[index];
                array[index] = array[i];
                array[i] = tmp;
            }
            return array;
        }
        static int IndexOfSmallestNumber(int[] array, int startIndex)
        {
            int index = startIndex;
            for(int i = startIndex; i < array.Length; i++)
            {
                if (array[i] < array[index]) { index = i; }
            }
            return index;
        }
    }
}
