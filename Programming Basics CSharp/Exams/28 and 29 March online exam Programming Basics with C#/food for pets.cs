using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double countDays = 0;
            double foodDog = 0.00;
            double foodCat = 0.00;
            double biscuits = 0.00;
            double totalBiscuits = 0.00;

            for (int i = 1; i <= days; i++)
            {
                double eatenFoodForDog = double.Parse(Console.ReadLine());
                double eatenFoodForCat = double.Parse(Console.ReadLine());

                countDays++;

                foodDog += eatenFoodForDog;
                foodCat += eatenFoodForCat;

                if (countDays==3)
                {
                    biscuits = eatenFoodForDog + eatenFoodForCat;
                    biscuits *= 0.1;
                    totalBiscuits += biscuits;
                    countDays = 0;
                }
            }
            double eatenFood = foodCat + foodDog;
            double totalPercentage = (eatenFood / food) * 100;
            double catsPercentage = (foodCat / eatenFood) * 100;
            double dogsPercentage = (foodDog / eatenFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {totalBiscuits:F0}gr.");
            Console.WriteLine($"{totalPercentage:F2}% of the food has been eaten.");
            Console.WriteLine($"{dogsPercentage:F2}% eaten from the dog.");
            Console.WriteLine($"{catsPercentage:F2}% eaten from the cat.");

        }
    }
}