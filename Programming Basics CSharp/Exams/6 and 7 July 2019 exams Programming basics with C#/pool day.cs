using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double countPeople = double.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double pricePerOneDeckChair = double.Parse(Console.ReadLine());
            double pricePerOneUmbrella = double.Parse(Console.ReadLine());

            double umbrella = countPeople;

            //deck chair
            double price = countPeople * entranceFee;
            countPeople = Math.Ceiling(countPeople * 0.75);
            countPeople *= pricePerOneDeckChair;

            //umbrella
            umbrella = Math.Ceiling(umbrella * 0.5);
            umbrella *= pricePerOneUmbrella;

            double totalPrice = price + countPeople + umbrella;

            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}

