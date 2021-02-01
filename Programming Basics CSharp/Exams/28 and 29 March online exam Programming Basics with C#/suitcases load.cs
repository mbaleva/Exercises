using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());

            int count = 0;
            int counter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }


                double currentNumber = double.Parse(command);
                count++;

                if (count==3)
                {
                    currentNumber *= 1.1;
                    count = 0;
                }
                capacity -= currentNumber;
                if (capacity < 0)
                {
                    break;
                }
                counter++;

            }
            if (capacity>=0)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {counter} suitcases loaded.");
            }
            else
            {
                Console.WriteLine($"No more space!");
                Console.WriteLine($"Statistic: {counter} suitcases loaded.");
            }
        }
    }
}

