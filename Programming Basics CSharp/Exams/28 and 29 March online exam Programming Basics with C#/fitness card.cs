using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string djender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0.00;

            if (djender=="m")
            {
                if (sport=="Gym")
                {
                    price += 42;
                }
                else if (sport=="Boxing")
                {
                    price += 41;
                }
                else if (sport == "Yoga")
                {
                    price += 45;
                }
                else if (sport == "Zumba")
                {
                    price += 34;
                }
                else if (sport == "Dances")
                {
                    price += 51;
                }
                else if (sport == "Pilates")
                {
                    price +=39;
                }
            }
            else if (djender == "f")
            {
                if (sport == "Gym")
                {
                    price += 35;
                }
                else if (sport == "Boxing")
                {
                    price += 37;
                }
                else if (sport == "Yoga")
                {
                    price += 42;
                }
                else if (sport == "Zumba")
                {
                    price += 31;
                }
                else if (sport == "Dances")
                {
                    price += 53;
                }
                else if (sport == "Pilates")
                {
                    price += 37;
                }
            }
            if (age<=19)
            {
                price *= 0.8;
            }
            if (budjet>=price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double diff = budjet - price;
                Console.WriteLine($"You don't have enough money! You need ${Math.Abs(diff):F2} more.");
            }
        }
    }
}

