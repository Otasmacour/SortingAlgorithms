using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class QuickSort
    {
        //https://www.youtube.com/watch?v=Vtckgz38QHs
        //For a better understanding of the Partition method, I highly recommend watching the visualization at the beginning.
        public void Sort(int[] array)
        {
            sort(array, 0, array.Length - 1);
        }
        public void sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                sort(array, left, pivotIndex - 1);
                sort(array, pivotIndex + 1, right);
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, j, i);
                }
            }
            Swap(arr, right, i+1);
            return i + 1;
        }

        static void Swap(int[] array, int left, int right)
        {
            int tmp = array[left];
            array[left] = array[right];
            array[right] = tmp;
        }
    }
}