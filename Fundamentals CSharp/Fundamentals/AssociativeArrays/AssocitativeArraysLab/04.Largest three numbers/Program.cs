using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Largest_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            int[] sortedNums = arr.OrderByDescending(n => n).ToArray();

            int counter = 0;
            for (int i = 0; i < sortedNums.Length; i++)
            {
                Console.Write(sortedNums[i]+" ");
                counter++;
                if (counter==3)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
