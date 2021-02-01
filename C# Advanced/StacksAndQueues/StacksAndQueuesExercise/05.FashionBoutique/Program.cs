using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(integers);
            int counter = 1;
            int sum = 0;

            while (stack.Count>0)
            {
                sum += stack.Peek();

                if (sum<=capacity)
                {
                    stack.Pop();
                }
                else
                {
                    sum = 0;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
