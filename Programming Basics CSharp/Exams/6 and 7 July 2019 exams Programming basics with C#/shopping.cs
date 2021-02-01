using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double countVideoCard = double.Parse(Console.ReadLine());
            double countCPU = double.Parse(Console.ReadLine());
            double countRAM = double.Parse(Console.ReadLine());

            double pricePerVideoCard = countVideoCard * 250;

            double CPUprice = pricePerVideoCard * 0.35;
            CPUprice *= countCPU;

            double RAMprice = pricePerVideoCard * 0.1;
            RAMprice *= countRAM;

            double totalPrice = RAMprice + CPUprice + pricePerVideoCard;

            if (countVideoCard>countCPU)
            {
                totalPrice *= 0.85;
            }
            double diff = budjet - totalPrice;

            if (totalPrice<=budjet)
            {
                Console.WriteLine($"You have {diff:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(diff):F2} leva more!");
            }

        }
    }
}

