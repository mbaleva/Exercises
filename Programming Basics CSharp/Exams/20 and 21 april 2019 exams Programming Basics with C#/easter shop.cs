using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startEggs = int.Parse(Console.ReadLine());
            int soldEggs = 0;
            int neededEggs = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Close")
                {
                    Console.WriteLine($"Store is closed!");
                    Console.WriteLine($"{soldEggs} eggs sold.");
                    break;
                }
                int currentNumber = int.Parse(Console.ReadLine());
                if (command == "Buy")
                {
                    startEggs -= currentNumber;
                    soldEggs += currentNumber;
                }
                else
                {
                    startEggs += currentNumber;
                }
                if (startEggs < 0)
                {
                    neededEggs = currentNumber - Math.Abs(startEggs);
                    Console.WriteLine($"Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {neededEggs}.");
                    break;
                }
            }

        }
    }
}
