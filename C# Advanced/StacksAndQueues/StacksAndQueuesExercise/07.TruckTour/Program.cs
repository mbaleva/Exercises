using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                queue.Enqueue(input);
            }
            int totalFuel = 0;
            for (int i = 0; i < n; i++)
            {
                string currentInfo = queue.Dequeue();
                var splitted = currentInfo
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var fuel = splitted[0];
                var distance = splitted[1];
                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i=-1;
                }
                queue.Enqueue(currentInfo);
            }
            var firstElement = queue.Dequeue().Split().ToArray();
            Console.WriteLine(firstElement[2]);
        }
    }
}
