using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWin = 0;
            int countLoss = 0;
            int countDrawn = 0;
            for (int i = 1; i <= 3; i++)
            {
                string result = Console.ReadLine();
                char score1 = result[0];
                char score2 = result[2];

                if (score1 > score2)
                {
                    countWin++;
                }
                else if (score1 < score2)
                {
                    countLoss++;
                }
                else if (score1 == score2)
                {
                    countDrawn++;

                }
            }
            Console.WriteLine($"Team won {countWin} games.");
            Console.WriteLine($"Team lost {countLoss} games.");
            Console.WriteLine($"Drawn games: {countDrawn}");
        }
    }
}
