using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurance = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (item!=' ')
                {
                    if (!occurance.ContainsKey(item))
                    {
                        occurance.Add(item, 0);
                    }
                    occurance[item]++;
                }
            }

            foreach (var item in occurance)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
