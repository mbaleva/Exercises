using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] variable = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

            int start = variable[0];
            int end = variable[1];


            List<int> list = new List<int>();

            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }

            string command = Console.ReadLine();

            if (command=="even")
            {
                Console.WriteLine(string.Join(" ", list.Where(x=>x%2==0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", list.Where(x=>x%2!=0)));
            }
        }
    }
}
