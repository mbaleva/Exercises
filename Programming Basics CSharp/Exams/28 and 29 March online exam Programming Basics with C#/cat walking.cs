using System;


namespace NestedLoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int walkingCount = int.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());

            int walkingMinutes = minutes * walkingCount;
            int caloriesDown = walkingMinutes * 5;

            double neededCalories = calories / 2;

            

            if (caloriesDown>=neededCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesDown}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesDown}.");
            }
        }
    }
}
