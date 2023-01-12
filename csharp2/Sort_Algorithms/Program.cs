using System;

namespace Sort_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 3, 5, 9, 7, 8, 6, 0 };

            // Sort_Algorithms.BubbleSort(arr);

            // Sort_Algorithms.SelectionSort(arr);

            Sort_Algorithms.InsertionSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
