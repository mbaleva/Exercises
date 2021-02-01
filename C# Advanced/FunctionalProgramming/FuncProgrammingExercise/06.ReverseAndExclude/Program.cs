using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> variable = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            int n = int.Parse(Console.ReadLine());

           variable.Reverse();

            variable = variable.Where(x => x % n != 0).ToList();
            Console.WriteLine(string.Join(" ", variable));
        }
    }
}
