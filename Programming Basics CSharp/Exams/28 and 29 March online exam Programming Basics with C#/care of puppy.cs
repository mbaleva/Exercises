using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = (int.Parse(Console.ReadLine())) * 1000;
            double sum = 0.00;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Adopted")
                {
                    break;
                }
                double eatenFoodPerDay = double.Parse(command);

                sum += eatenFoodPerDay;
            }
            if (sum<=food)
            {
                double diff = food - sum;
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
            else
            {
                double diff = sum - food;
                Console.WriteLine($"Food is not enough. You need {diff} grams more.");
            }
        }
    }
}

