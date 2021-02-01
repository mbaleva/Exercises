using System;

namespace brum
{
    class Program
    {
        static void Main(string[] args)
        {
            string level = Console.ReadLine();
            string kindTickets = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());
            string picture = Console.ReadLine();


            double totalPrice = 0.00;

            if (picture == "Y")
            {
                if (level == "Final")
                {
                    if (kindTickets == "Standard")
                    {
                        totalPrice = countTickets * 110.1;
                    }
                    else if (kindTickets == "Premium")
                    {
                        totalPrice = countTickets * 160.66;
                    }
                    else
                    {
                        //VIP
                        totalPrice = countTickets * 400;
                    }
                }
                if (level == "Semi final")
                {
                    if (kindTickets == "Standard")
                    {
                        totalPrice = countTickets * 75.88;
                    }
                    else if (kindTickets == "Premium")
                    {
                        totalPrice = countTickets * 125.22;
                    }
                    else
                    {
                        //VIP
                        totalPrice = countTickets * 300.4;
                    }
                }
                if (level == "Quarter final")
                {
                    if (kindTickets == "Standard")
                    {
                        totalPrice = countTickets * 55.5;
                    }
                    else if (kindTickets == "Premium")
                    {
                        totalPrice = countTickets * 105.2;
                    }
                    else
                    {
                        //VIP
                        totalPrice = countTickets * 118.9;
                    }
                }
                if (totalPrice > 4000)
                {
                    totalPrice *= 0.75;
                }
                else
                {
                    if (totalPrice > 2500)
                    {
                        totalPrice *= 0.9;
                    }
                    double diff = countTickets * 40;
                    totalPrice += diff;
                   
                }
                
            }
            if (picture == "N")
            {
                if (level == "Final")
                {
                    if (kindTickets == "Standard")
                    {
                        totalPrice = countTickets * 110.1;
                    }
                    else if (kindTickets == "Premium")
                    {
                        totalPrice = countTickets * 160.66;
                    }
                    else
                    {
                        //VIP
                        totalPrice = countTickets * 400;
                    }
                }
                if (level == "Semi final")
                {
                    if (kindTickets == "Standard")
                    {
                        totalPrice = countTickets * 75.88;
                    }
                    else if (kindTickets == "Premium")
                    {
                        totalPrice = countTickets * 125.22;
                    }
                    else
                    {
                        //VIP
                        totalPrice = countTickets * 300.4;
                    }
                }
                if (level == "Quarter final")
                {
                    if (kindTickets == "Standard")
                    {
                        totalPrice = countTickets * 55.5;
                    }
                    else if (kindTickets == "Premium")
                    {
                        totalPrice = countTickets * 105.2;
                    }
                    else
                    {
                        //VIP
                        totalPrice = countTickets * 118.9;
                    }
                }
                if (totalPrice > 4000)
                {
                    totalPrice *= 0.75;
                }
                else
                {

                    if (totalPrice > 2500)
                    {
                        totalPrice *= 0.9;
                    }
                }
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
