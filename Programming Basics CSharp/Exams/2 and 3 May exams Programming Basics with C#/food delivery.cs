using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChicken = int.Parse(Console.ReadLine());
            int countFish = int.Parse(Console.ReadLine());
            int veganCount = int.Parse(Console.ReadLine());

            double chickenPrice = countChicken * 10.35;
            double fishPrice = countFish * 12.4;
            double veganPrice = veganCount * 8.15;

            double price = chickenPrice + fishPrice + veganPrice;
            double discount = price * 0.2;
            double totalPrice = price + discount + 2.5;

            Console.WriteLine($"Total: {totalPrice:F2}");
            

        }
    }
}