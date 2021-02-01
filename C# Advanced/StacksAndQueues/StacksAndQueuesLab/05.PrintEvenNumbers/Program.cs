using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> evenNums = new Queue<int>(
            //                      Console.ReadLine()
            //                     .Split()
            //                     .Select(int.Parse)
            //                     .Where(x => x % 2 == 0));
            //Console.WriteLine(string.Join(", ", evenNums));

            List<int> input = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToList();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    queue.Enqueue(input[i]);
                }
            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
