using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());

            double totalPrice = 0.00;

            if (season == "Winter")
            {
                if (destination == "Dubai")
                {
                    totalPrice = countDays * 45000;
                    totalPrice *= 0.7;
                }
                else if (destination == "Sofia")
                {
                    totalPrice = countDays * 17000;
                    totalPrice *= 1.25;
                }
                else if (destination == "London")
                {
                    totalPrice = countDays * 24000;
                }
            }
            else
            {
                if (destination == "Dubai")
                {
                    totalPrice = countDays * 40000;
                    totalPrice *= 0.7;
                }
                else if (destination == "Sofia")
                {
                    totalPrice = countDays * 12500;
                    totalPrice *= 1.25;
                }
                else if (destination == "London")
                {
                    totalPrice = countDays * 20250;
                }
            }
            double diff = budjet - totalPrice;
            if (budjet>=totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {diff:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {Math.Abs(diff):F2} leva more!");
            }
        }
    }
}