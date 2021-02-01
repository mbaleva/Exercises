using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countTickets = 0;
            int count = 0;
            int moviePrice = 0;

            while (money>=0)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                if (command.Length > 8)
                {
                   
                    moviePrice = command[0] + command[1];
                   
                    money -= moviePrice;
                    if (money>=0)
                    {
                        countTickets++;

                    }
                }
                else if (command.Length <= 8)
                {
                  
                    moviePrice = command[0];
                    
                    money -= moviePrice;
                    if (money>=0)
                    {
                        count++;
                    }
                    
                }
            }
            Console.WriteLine($"{countTickets}");
            Console.WriteLine($"{count}");
        }
    }
}

