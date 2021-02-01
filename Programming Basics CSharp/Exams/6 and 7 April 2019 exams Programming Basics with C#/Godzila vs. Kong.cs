using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double countS = double.Parse(Console.ReadLine());
            double pricePerOneS = double.Parse(Console.ReadLine());

            double statistTotalPrice = pricePerOneS * countS;
            double decor = budjet * 0.1;

            if (countS>=150)
            {
                statistTotalPrice *= 0.9;
            }
            double totalPrice = decor + statistTotalPrice;
            if (totalPrice>budjet)
            {
                double diff = totalPrice - budjet;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {diff:F2} leva more.");
            }
            else
            {
                double diff = budjet - totalPrice;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {diff:F2} leva left.");
            }
        }
    }
}
