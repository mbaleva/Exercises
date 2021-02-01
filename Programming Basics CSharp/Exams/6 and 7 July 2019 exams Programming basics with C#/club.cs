using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());

            int pricePerOneDrink = 0;
            double sum = 0.00;
            double totalPrice = 0.00;
            while (true)
            {
                string name = Console.ReadLine();

                if (name == "Party!")
                {
                    break;
                }

                int orders = int.Parse(Console.ReadLine());

                pricePerOneDrink = name.Length;
                sum = pricePerOneDrink * orders;

                if (sum%2!=0)
                {
                    sum *= 0.75;
                }
                totalPrice += sum;
                sum = 0;
                if (totalPrice>=neededMoney)
                {
                    break;
                }

            }
            if (totalPrice>=neededMoney)
            {
                Console.WriteLine($"Target acquired.");
                Console.WriteLine($"Club income - {totalPrice:F2} leva.");
            }
            else
            {
                double diff = neededMoney - totalPrice;
                Console.WriteLine($"We need {diff:F2} leva more.");
                Console.WriteLine($"Club income - {totalPrice:F2} leva.");

            }
        }
    }
}
