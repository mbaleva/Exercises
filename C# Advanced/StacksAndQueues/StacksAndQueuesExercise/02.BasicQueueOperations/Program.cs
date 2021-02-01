using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.BasicQueueOperations
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

            Queue<int> queue = new Queue<int>(
                               Console.ReadLine()
                              .Split()
                              .Select(int.Parse));
            for (int i = 1; i <= elementsToPop; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }
            if (queue.Contains(isContainsThatElement))
            {
                Console.WriteLine("true");

            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
