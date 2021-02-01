using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsForFirstPlayer = int.Parse(Console.ReadLine());
            int eggsForSecondPlayer = int.Parse(Console.ReadLine());

            string winner = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End of battle")
                {
                    Console.WriteLine($"Player one has {eggsForFirstPlayer} eggs left.");
                    Console.WriteLine($"Player two has {eggsForSecondPlayer} eggs left.");
                    break;
                }

                if (command == "one")
                {
                    winner = "one";
                    eggsForSecondPlayer--;
                }
                else
                {
                    winner = "two";
                    eggsForFirstPlayer--;
                }
                if (eggsForFirstPlayer==0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsForSecondPlayer} eggs left.");

                    break;
                }
                if (eggsForSecondPlayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsForFirstPlayer} eggs left.");

                    break;
                }
            }
        }
    }
}
