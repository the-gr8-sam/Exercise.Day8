using System;
using static System.Console;

namespace Samarth.Day8.Exercise
{
    internal class LargestNumberQue
    {
        static void Main(string[] args)
        {
            WriteLine("Array Size :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            WriteLine("Array Elements :");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            WriteLine(String.Join("",arr));
        }
    }
}
