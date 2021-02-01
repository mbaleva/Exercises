using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string typeRoom = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());

            double totalPrice = 0.00;

            if (filmName == "A Star Is Born")
            {
                if (typeRoom=="normal")
                {
                    totalPrice = 7.5 * countTickets;
                }
                else if (typeRoom=="luxury")
                {
                    totalPrice = 10.5 * countTickets;
                }
                else if (typeRoom == "ultra luxury")
                {
                    totalPrice = 13.5 * countTickets;
                }
            }
            else if (filmName == "Bohemian Rhapsody")
            {
                if (typeRoom == "normal")
                {
                    totalPrice = 7.35 * countTickets;
                }
                else if (typeRoom == "luxury")
                {
                    totalPrice = 9.45 * countTickets;
                }
                else if (typeRoom == "ultra luxury")
                {
                    totalPrice = 12.75 * countTickets;
                }
            }
            else if (filmName == "Green Book")
            {
                if (typeRoom == "normal")
                {
                    totalPrice = 8.15 * countTickets;
                }
                else if (typeRoom == "luxury")
                {
                    totalPrice = 10.25 * countTickets;
                }
                else if (typeRoom == "ultra luxury")
                {
                    totalPrice = 13.25 * countTickets;
                }
            }
            else if (filmName == "The Favourite")
            {
                if (typeRoom == "normal")
                {
                    totalPrice = 8.75 * countTickets;
                }
                else if (typeRoom == "luxury")
                {
                    totalPrice = 11.55 * countTickets;
                }
                else if (typeRoom == "ultra luxury")
                {
                    totalPrice = 13.95 * countTickets;
                }
            }
            Console.WriteLine($"{filmName} -> {totalPrice:F2} lv.");
        }
    }
}
