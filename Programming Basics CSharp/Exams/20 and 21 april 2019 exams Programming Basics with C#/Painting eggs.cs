using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double price = 0.00;

            if (size == "Large")
            {
                if (color == "Red")
                {
                    price = 16 * count;
                }
                else if (color == "Green")
                {
                    price = 12 * count;
                }
                else if (color == "Yellow")
                {
                    price = 9 * count;
                }
            }
            else if (size == "Medium")
            {
                if (color == "Red")
                {
                    price = 13 * count;
                }
                else if (color == "Green")
                {
                    price = 9 * count;
                }
                else if (color == "Yellow")
                {
                    price = 7 * count;
                }
            }
            else if (size == "Small")
            {
                if (color == "Red")
                {
                    price = 9 * count;
                }
                else if (color == "Green")
                {
                    price = 8 * count;
                }
                else if (color == "Yellow")
                {
                    price = 5 * count;
                }
            }
            price *= 0.65;
            Console.WriteLine($"{price:F2} leva.");
        }
    }
}
