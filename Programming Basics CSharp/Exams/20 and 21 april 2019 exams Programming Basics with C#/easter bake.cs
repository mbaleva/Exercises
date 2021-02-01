using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;

            double sumSugar = 0.00;
            double sumFlour = 0.00;

            for (int i = 1; i <= n; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                sumSugar += sugar;
                sumFlour += flour;

                if (sugar>maxSugar)
                {
                    maxSugar = sugar;
                }
                if (flour>maxFlour)
                {
                    maxFlour = flour;
                }
            }
            double packageSugar = Math.Ceiling(sumSugar / 950);
            double packageFlour = Math.Ceiling(sumFlour  /750);

            Console.WriteLine($"Sugar: {packageSugar}");
            Console.WriteLine($"Flour: {packageFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}