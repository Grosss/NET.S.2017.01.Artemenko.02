using System;
using System.Linq;

namespace Task1
{
    public static class Sorting
    {
        public static void MergeSort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            if (array.Length == 0)
                throw new ArgumentException();
            
            array = Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        #region Private methods
        private static int[] Sort(int[] array)
        {
            if (array.Length == 1)
                return array;
            Console.WriteLine("OLOLO");
            return Merge(Sort(array.Take(array.Length / 2).ToArray()), Sort(array.Skip(array.Length / 2).ToArray()));
        }        
        
        private static int[] Merge(int[] leftPart, int[] rightPart)
        {
            int leftPartIndex = 0, rightPartIndex = 0;
            int[] mergedArray = new int[leftPart.Length + rightPart.Length];
            for (int i = 0; i < leftPart.Length + rightPart.Length; i++)
            {
                if (leftPartIndex < leftPart.Length && rightPartIndex < rightPart.Length)
                    if (leftPart[leftPartIndex] > rightPart[rightPartIndex])
                        mergedArray[i] = rightPart[rightPartIndex++];
                    else
                        mergedArray[i] = leftPart[leftPartIndex++];
                else
                    if (rightPartIndex < rightPart.Length)
                    mergedArray[i] = rightPart[rightPartIndex++];
                else
                    mergedArray[i] = leftPart[leftPartIndex++];
            }
            for (int i = 0; i < mergedArray.Length; i++)
            {
                Console.Write(mergedArray[i] + " ");
            }
            Console.WriteLine();
            return mergedArray;
        }
        #endregion
    }
}