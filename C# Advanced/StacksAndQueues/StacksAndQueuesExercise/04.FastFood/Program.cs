using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);
            Console.WriteLine(queue.Max());
            while (queue.Count>0)
            {
                var food = queue.Peek();

                if (foodAmount>=food)
                {
                    foodAmount -= food;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queue.Count>0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
