using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_negatives_and_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.RemoveAll(n => n < 0);
            if (input.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                input.Reverse();
                Console.WriteLine(String.Join(" ",input));
            }
        }
    }
}
