using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededPaper = double.Parse(Console.ReadLine());
            double neededPaint = double.Parse(Console.ReadLine());
            double neededThinner = double.Parse(Console.ReadLine());
            double neededHours = double.Parse(Console.ReadLine());

            double paperPrice = (neededPaper + 2) * 1.5;
            double paintPrice = (neededPaint * 1.1) * 14.5;
            double thinnerPrice = neededThinner * 5;

            double price = paperPrice + paintPrice + thinnerPrice + 0.4;
            double pricePerMaterials = price;
            price *= 0.3;
            price *= neededHours;
            price += pricePerMaterials;

            Console.WriteLine($"Total expenses: {price:F2} lv.");
        }
    }
}
