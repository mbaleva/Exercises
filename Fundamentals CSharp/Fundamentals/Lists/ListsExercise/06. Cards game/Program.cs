using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                int firstPlayerCard = firstPlayer[0];
                int secondPlayerCard = secondPlayer[0];
                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayer.Add(firstPlayerCard);
                    firstPlayer.Add(secondPlayerCard);
                }
                else if (secondPlayerCard>firstPlayerCard)
                {
                    secondPlayer.Add(secondPlayerCard);
                    secondPlayer.Add(firstPlayerCard);
                }
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }
            if (firstPlayer.Sum() > secondPlayer.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
