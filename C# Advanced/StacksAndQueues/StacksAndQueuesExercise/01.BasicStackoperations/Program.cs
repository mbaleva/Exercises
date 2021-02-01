using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.BasicStackoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                       .Split(' ')
                       .Select(int.Parse)
                       .ToArray();

            int elementsToPop = arr[1];
            int isContainsThatElement = arr[2];

            Stack<int> stack = new Stack<int>(
                               Console.ReadLine()
                              .Split()
                              .Select(int.Parse));
            for (int i = 1; i <= elementsToPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            if (stack.Contains(isContainsThatElement))
            {
                Console.WriteLine("true");

            }
            else if (stack.Count>0)
            {
                Console.WriteLine(stack.Min());
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }

        }
    }
}
