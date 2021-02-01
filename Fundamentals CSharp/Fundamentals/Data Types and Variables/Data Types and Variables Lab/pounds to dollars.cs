using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dollars = pounds * 1.31M;

            Console.WriteLine($"{dollars:F3}");
        }
    }
}