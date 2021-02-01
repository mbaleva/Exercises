using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] variable = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();
            Array.Sort(variable, (x,y)=>
            {
                int sorted = 0;

                if (x%2==0&&y%2!=0)
                {
                    sorted = -1;
                }
                else if (x%2!=0&&y%2==0)
                {
                    sorted = 1;
                }
                else
                {
                    sorted = x.CompareTo(y);
                }
                return sorted;
            });

            Console.WriteLine(string.Join(" ", variable));
        }
    }
}
