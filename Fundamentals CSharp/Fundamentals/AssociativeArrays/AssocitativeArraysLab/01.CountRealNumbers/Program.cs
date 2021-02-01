using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> nums = new SortedDictionary<double, int>();

            int[] arr = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            foreach (int item in arr)
            {
                if (nums.ContainsKey(item))
                {
                    nums[item]++;
                }
                else
                {
                    nums.Add(item, 1);
                }
            }

            foreach (var item in nums)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
