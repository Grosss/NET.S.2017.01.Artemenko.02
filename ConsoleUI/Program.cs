using System;
using Sorting;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 101);
            Console.WriteLine("Before sorting:");
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
            arr = MergeSort.Sort(arr);
            Console.WriteLine("After sorting:");
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.ReadLine();
        }
    }
}