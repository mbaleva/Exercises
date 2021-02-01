using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num = int.Parse(Console.ReadLine());

            //List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            //int sum = int.MinValue;
            //foreach (var item in list)
            //{
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        sum += item[i];
            //    }
            //    if (sum>=num)
            //    {
            //        Console.WriteLine(item);
            //        Environment.Exit(0);
            //    }
            //    sum = 0;
            //}

            int nums = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> isValidWord = (strings, num) => strings.ToCharArray()
                .Select(x => (int)x).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> name = (arr, num, func) => arr
                .FirstOrDefault(x => func(x, num));

            var result = name(names, nums, isValidWord);
            Console.WriteLine(result);
        }
    }
}
