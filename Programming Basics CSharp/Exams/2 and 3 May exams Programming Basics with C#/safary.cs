using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double fuelPrice = liters * 2.1;
            double price = fuelPrice + 100;

            if (dayOfWeek== "Saturday")
            {
                price *= 0.9;

            }
            else
            {
                price *= 0.8;
            }
            double diff = budjet - price;
            if (price<=budjet)
            {
                Console.WriteLine($"Safari time! Money left: {diff:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {Math.Abs(diff):F2} lv.");
            }
        }
    }
}