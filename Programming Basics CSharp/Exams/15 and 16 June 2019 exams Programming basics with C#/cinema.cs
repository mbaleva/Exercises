using System;
using System.Data;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            double price = 0.00;
            double totalPrice = 0.00;

            int countTickets = 0;

            bool isBreak = false;
            bool isCapacity = false;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Movie time!")
                {
                    isBreak = true;
                    break;
                }
                int tickets = int.Parse(command);
                countTickets += tickets;

                if (countTickets<=capacity)
                {
                    price = tickets * 5;

                    if (tickets % 3 == 0)
                    {
                        price -= 5;
                    }
                    totalPrice += price;
                }
                
                if (countTickets > capacity)
                {
                    isCapacity = true;
                    break;
                }

                price = 0;
            }
            if (isBreak)
            {
                double diff = capacity - countTickets;
                Console.WriteLine($"There are {diff} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {totalPrice} lv.");
            }
            if (isCapacity)
            {
                Console.WriteLine($"The cinema is full.");
                Console.WriteLine($"Cinema income - {totalPrice} lv.");
            }

            
        }
    }
}