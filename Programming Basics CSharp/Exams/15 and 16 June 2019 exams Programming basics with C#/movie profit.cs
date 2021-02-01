using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());
            int countTickets = int.Parse(Console.ReadLine());
            double pricePerOneticket = double.Parse(Console.ReadLine());
            double percentageForCinema = double.Parse(Console.ReadLine());

            double price = (countTickets * pricePerOneticket) * countDays;
            double priceForCinema = price * percentageForCinema/100;

            double totalPrice = price - priceForCinema;

            Console.WriteLine($"The profit from the movie {filmName} is {totalPrice:F2} lv.");
        }
    }
}