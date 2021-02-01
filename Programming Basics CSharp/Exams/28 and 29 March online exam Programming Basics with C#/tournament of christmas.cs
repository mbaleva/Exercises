using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int countWin = 0;
            int countLoss = 0;

            int countTotalWin = 0;
            int countTotalLoss = 0;

            double totalSum = 0.00;
            double sum = 0.00;

            for (int i = 1; i <= days; i++)
            {
                string sport = Console.ReadLine();

                while (sport!="Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        sum += 20;
                        countWin++;
                        countTotalWin++;
                    }
                    else
                    {
                        countLoss++;
                        countTotalLoss++;
                    }
                    sport = Console.ReadLine();
                    
                }
                if (countWin > countLoss)
                {
                    sum *= 1.1;
                }
                totalSum += sum;
                countWin = 0;
                countLoss = 0;
                sum = 0;

            }
            if (countTotalWin > countTotalLoss)
            {
                totalSum *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalSum:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalSum:F2}");
            }

        }
    }
}

