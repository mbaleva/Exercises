using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|', StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            input.Reverse();


            List<string> output = new List<string>();
            foreach (string currentItem in input)
            {
                string[] arr = currentItem.Split(' ', 
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (string item in arr)
                {
                    output.Add(item);
                }
            }
            Console.WriteLine(string.Join(' ', output));
        }
    }
}
