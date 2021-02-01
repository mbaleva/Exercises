using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_adjacent_equal_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                int nextIndex = 0;
                if (i + 1 > input.Count - 1)
                {
                    break;
                }
                else
                {
                    nextIndex = i + 1;
                }

                if (input[i] == input[nextIndex])
                {
                    input[i] += input[nextIndex];
                    input.RemoveAt(nextIndex);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
