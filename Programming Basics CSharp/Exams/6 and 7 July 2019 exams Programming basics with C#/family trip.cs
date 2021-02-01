using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double countNights = double.Parse(Console.ReadLine());
            double pricePerOneNight = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double price = 0.00;
            double discount = 0.00;
            double totalPrice = 0.00;

            if (countNights>7)
            {
                pricePerOneNight *= 0.95;
                
                price = pricePerOneNight * countNights;
                
                discount =(percentage/100) *budjet;
                totalPrice = price + discount;

                if (totalPrice<=budjet)
                {
                    double diff = budjet - totalPrice;
                    Console.WriteLine($"Ivanovi will be left with {diff:F2} leva after vacation.");
                }
                else
                {
                    double diff = totalPrice - budjet;
                    Console.WriteLine($"{diff:F2} leva needed.");
                }
            }
            else
            {
                price = pricePerOneNight * countNights;
                discount = (percentage / 100) * budjet;
                totalPrice = price + discount;

                if (totalPrice <= budjet)
                {
                    double diff = budjet - totalPrice;
                    Console.WriteLine($"Ivanovi will be left with {diff:F2} leva after vacation.");
                }
                else
                {
                    double diff = totalPrice - budjet;
                    Console.WriteLine($"{diff:F2} leva needed.");
                }
            }
        }
    }
}

