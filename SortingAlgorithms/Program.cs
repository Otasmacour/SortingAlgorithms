using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 17, 4, 8, 1, 3, -93, 1, 0, -6 };
            Console.WriteLine("Original array"); PrintArray(array);
            BubbleSort bubble = new BubbleSort();
            //array = bubble.Sort(array);
            MergeSort mergeSort = new MergeSort();
            array = mergeSort.Sort(array);
            Console.WriteLine("Sorted array"); PrintArray(array);
            Console.ReadLine();
        }
        static void PrintArray(int[] array)
        {
            Console.Write('[');
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(" " + array[i]);
                }
                else
                {
                    Console.Write(" " + array[i] + ",");
                }
            }
            Console.Write(']');
            Console.WriteLine();
        }
    }
}