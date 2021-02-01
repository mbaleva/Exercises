using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());

            int counter = 0;
            int totalCounter = 0;
            double price = 0.00;

            bool meow = true;

            while (true)
            {
                string productName = Console.ReadLine();

                if (productName == "Stop")
                {
                    Console.WriteLine($"You bought {totalCounter} products for {price:F2} leva.");
                    Environment.Exit(0);
                }
                double productPrice = double.Parse(Console.ReadLine());
                counter++;
                totalCounter++;

                if (counter == 3)
                {
                    productPrice *= 0.5;
                    counter = 0;
                }
                price += productPrice;


                if (price > budjet)
                {
                    double diff = price - budjet;
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {diff:F2} leva!");
                    Environment.Exit(0);
                }
            }
          
            
        }
    }
}
