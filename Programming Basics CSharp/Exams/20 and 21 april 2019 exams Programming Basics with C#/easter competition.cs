using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0.00;
            double max = double.MinValue;
            string winnerName = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "Stop")
                    {
                        break;
                    }
                    double result = double.Parse(command);
                    sum += result;

                }
                Console.WriteLine($"{name} has {sum} points.");
                if (sum>max)
                {
                    max = sum;
                    winnerName = name;
                    Console.WriteLine($"{name} is the new number 1!");
                }
                sum = 0;
            }
            Console.WriteLine($"{winnerName} won competition with {max} points!");
        }
    }
}
