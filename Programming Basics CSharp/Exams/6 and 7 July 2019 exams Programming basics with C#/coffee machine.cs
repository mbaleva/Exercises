using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countDrinks = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (drink == "Espresso")
            {
                if (sugar == "Without")
                {
                    price = price + countDrinks * 0.9;
                    price *= 0.65;
                }
                else if (sugar == "Normal")
                {
                    price =price +  countDrinks * 1;
                }
                else if (sugar == "Extra")
                {
                    price = price + countDrinks * 1.2;
                }
                if (countDrinks >= 5)
                {
                    price *= 0.75;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    price = price + countDrinks * 1;
                    price *= 0.65;
                }

                else if (sugar == "Normal")
                {
                    price = price + countDrinks * 1.2;
                }
                else if (sugar == "Extra")
                {
                    price = price + countDrinks * 1.6;
                }
            }
            else if (drink == "Tea")
            {
                if (sugar == "Without")
                {
                    price = price + countDrinks * 0.5;
                    price *= 0.65;
                }

                else if (sugar == "Normal")
                {
                    price = price + countDrinks * 0.6;
                }
                else if (sugar == "Extra")
                {
                    price = price + countDrinks * 0.7;
                }

            }
            if (price > 15)
            {
                price *= 0.8;
            }
               Console.WriteLine($"You bought {countDrinks} cups of {drink} for {price:F2} lv.");
            
        }
    }
}