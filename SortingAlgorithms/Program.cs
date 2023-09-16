using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            Random random = new Random();
            int[] array = new int[10000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100,100); 
            }
            //Console.WriteLine("Original array"); PrintArray(array);
            BubbleSort bubble = new BubbleSort();
            //array = bubble.Sort(array);
            MergeSort mergeSort = new MergeSort();
            //array = mergeSort.Sort(array);
            InsertionSort insertionSort = new InsertionSort();
            //array = insertionSort.Sort(array);
            SelectionSort selectionSort = new SelectionSort();
            //array = selectionSort.Sort(array);
            QuickSort quickSort = new QuickSort();
            quickSort.Sort(array);
            //Console.WriteLine("Sorted array"); PrintArray(array);
            CorrectnessCheck(array);
            Console.WriteLine("Elapsed milliseconds: " + sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
        static void CorrectnessCheck(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length - 1; i++)
                {
                if (array[i] > array[i+1]) { Console.WriteLine("Sorted incorrectly"); return; }
            }
            Console.WriteLine("Sorted correctly");
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