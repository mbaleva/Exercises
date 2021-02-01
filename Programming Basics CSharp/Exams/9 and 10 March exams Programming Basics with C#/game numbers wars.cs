using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            int countPointsForFirstPlayer = 0;
            int countPointsForSecondPlayer = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End of game")
                {
                    Console.WriteLine($"{firstPlayerName} has {countPointsForFirstPlayer} points");
                    Console.WriteLine($"{secondPlayerName} has {countPointsForSecondPlayer} points");
                    break;
                }
                int firstCard = int.Parse(command);
                int secondCard = int.Parse(Console.ReadLine());

                if (firstCard>secondCard)
                {
                    countPointsForFirstPlayer += firstCard - secondCard;
                }
                else if (firstCard<secondCard)
                {
                    countPointsForSecondPlayer += secondCard - firstCard;
                }
                else if (firstCard==secondCard)
                {
                    while (true)
                    {
                        int card1 = int.Parse(Console.ReadLine());
                        int card2 = int.Parse(Console.ReadLine());

                        if (card1>card2)
                        {
                            Console.WriteLine($"Number wars!");
                            Console.WriteLine($"{firstPlayerName} is winner with {countPointsForFirstPlayer} points");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"Number wars!");
                            Console.WriteLine($"{secondPlayerName} is winner with {countPointsForSecondPlayer} points");
                            return;                        }
                    }
                }
               
            }
            
        }
    }
}
