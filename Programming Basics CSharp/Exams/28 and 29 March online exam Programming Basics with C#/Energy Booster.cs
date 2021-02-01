using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0.00;
            if (size == "small")
            {
                if (fruit == "Watermelon")
                {
                    price = (2 * 56)*count;
                }
                else if (fruit == "Mango")
                {
                    price = (2 * 36.66) * count;
                }
                else if (fruit == "Pineapple")
                {
                    price = (2 * 42.10) * count;
                }
                else if (fruit == "Raspberry")
                {
                    price = (2 * 20) * count;
                }
            }
            else if (size == "big")
            {
                if (fruit == "Watermelon")
                {
                    price = (5* 28.7) * count;
                }
                else if (fruit == "Mango")
                {
                    price = (5 * 19.6) * count;
                }
                else if (fruit == "Pineapple")
                {
                    price = (5 * 24.8) * count;
                }
                else if (fruit == "Raspberry")
                {
                    price = (5 * 15.2) * count;
                }
            }
            if (price>=400&&price<=1000)
            {
                price *= 0.85;
            }
            else if (price>1000)
            {
                price *= 0.5;
            }
            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
