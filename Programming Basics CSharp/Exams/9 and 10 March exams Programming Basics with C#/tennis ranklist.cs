using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double countWinner = 0;
            double countWin = 0;
            double countF = 0;
            double countSF = 0;
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();

                if (command == "F")
                {
                    startingPoints += 1200;
                    countF++;
                }
                else if (command == "SF")
                {
                    startingPoints += 720;
                    countSF++;
                }
                else if (command == "W")
                {
                    startingPoints += 2000;
                    countWin++;
                    countWinner++;
                }
            }
            double averagePoints = (countF * 1200 + countSF * 720 + countWin * 2000) / n;
            double percentage = (countWin / n) * 100;

            Console.WriteLine($"Final points: {startingPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentage:F2}%");
        }
    }
}
