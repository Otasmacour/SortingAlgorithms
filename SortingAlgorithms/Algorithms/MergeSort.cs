using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSort
    {
        public int[] Sort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            int[] Array1 = array.Take(array.Length / 2).ToArray();
            int[] Array2 = array.Skip(array.Length / 2).ToArray();
            Array1 = Sort(Array1);
            Array2 = Sort(Array2);
            return (Merge(Array1, Array2));
        }
        static int[] Merge(int[] arrayA, int[] arrayB)
        {
            int[] arrayC = new int[arrayA.Length + arrayB.Length];
            int indexA = 0;
            int indexB = 0;
            int indexC = 0;
            while (indexA < arrayA.Length && indexB < arrayB.Length)
            {
                if (arrayA[indexA] > arrayB[indexB])
                {
                    arrayC[indexC] = arrayB[indexB];
                    indexB++;
                }
                else
                {
                    arrayC[indexC] = arrayA[indexA];
                    indexA++;
                }
                indexC++;
            }
            while (indexA < arrayA.Length)
            {
                arrayC[indexC] = arrayA[indexA];
                indexC++;
                indexA++;
            }
            while (indexB < arrayB.Length)
            {
                arrayC[indexC] = arrayB[indexB];
                indexC++;
                indexB++;
            }
            return arrayC;
        }
    }
}