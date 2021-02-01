using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string serialName = Console.ReadLine();
                double pricePerSerial = double.Parse(Console.ReadLine());

                if (serialName=="Thrones")
                {
                    pricePerSerial *= 0.5;
                }
                else if (serialName == "Lucifer")
                {
                    pricePerSerial *= 0.6;
                }
                else if (serialName == "Protector")
                {
                    pricePerSerial *= 0.7;
                }
                else if (serialName == "TotalDrama")
                {
                    pricePerSerial *= 0.8;
                }
                else if (serialName == "Area")
                {
                    pricePerSerial *= 0.9;
                }
                budjet -= pricePerSerial;
            }
            if (budjet>=0)
            {
                Console.WriteLine($"You bought all the series and left with {budjet:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budjet):F2} lv. more to buy the series!");
            }
        }
    }
}