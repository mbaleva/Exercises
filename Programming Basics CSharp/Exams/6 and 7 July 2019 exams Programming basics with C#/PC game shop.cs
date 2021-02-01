using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double hearthstoneCount = 0;
            double forniteCount = 0;
            double overwatchCount = 0;
            double othersCount = 0;

            for (int i = 1; i <=n; i++)
            {
                string playName = Console.ReadLine();

                if (playName == "Hearthstone")
                {
                    hearthstoneCount++;
                }
                else if (playName == "Fornite")
                {
                    forniteCount++;
                }
                else if (playName == "Overwatch")
                {
                    overwatchCount++;
                }
                else
                {
                    //others
                    othersCount++;
                }
            }
            double hearthstonePercentage = (hearthstoneCount / n) * 100;
            double fornitePercentage = (forniteCount / n) * 100;
            double overwatchPercentage = (overwatchCount / n) * 100;
            double othersPercentage = (othersCount / n) * 100;

            Console.WriteLine($"Hearthstone - {hearthstonePercentage:F2}% ");
            Console.WriteLine($"Fornite - {fornitePercentage:F2}%");
            Console.WriteLine($"Overwatch - {overwatchPercentage:F2}%");
            Console.WriteLine($"Others - {othersPercentage:F2}%");
        }
    }
}

