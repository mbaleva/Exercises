using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string package = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());

            double totalPrice = 0.00;

            if (filmName=="John Wick")
            {
                if (package== "Drink")
                {
                    totalPrice = countTickets * 12;
                }
                else if (package == "Popcorn")
                {
                    totalPrice = countTickets * 15;
                }
                else
                {
                    //Menu
                    totalPrice = countTickets * 19;
                }
            }
            else if (filmName== "Star Wars")
            {
                if (package == "Drink")
                {
                    totalPrice = countTickets * 18;
                }
                else if (package == "Popcorn")
                {
                    totalPrice = countTickets * 25;
                }
                else if (package == "Menu")
                {
                    
                    totalPrice = countTickets * 30;
                }
                if (countTickets>=4)
                {
                    totalPrice *= 0.7;
                }
            }
            else if (filmName == "Jumanji")
            {
                if (package == "Drink")
                {
                    totalPrice = countTickets * 9;
                }
                else if (package == "Popcorn")
                {
                    totalPrice = countTickets * 11;
                }
                else if (package == "Menu")
                {
                    //Menu
                    totalPrice = countTickets * 14;
                }
                if (countTickets== 2)
                {
                    totalPrice *= 0.85;
                }
            }
            Console.WriteLine($"Your bill is {totalPrice:F2} leva.");
        }
    }
}