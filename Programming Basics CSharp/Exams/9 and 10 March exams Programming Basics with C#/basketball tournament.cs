using System;

namespace brum
{
    class Program
    {
        static void Main(string[] args)
        {
            double diff = 0.00;
            double winCounts = 0.00;
            double lossCounts = 0.00;
            string result = string.Empty;
            double totalMatch = 0.00;

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End of tournaments")
                {
                    double percentageWins = (winCounts / totalMatch) * 100;
                    double percentageLoss = (lossCounts / totalMatch) * 100;
                    Console.WriteLine($"{percentageWins:F2}% matches win");
                    Console.WriteLine($"{percentageLoss:F2}% matches lost");
                    Environment.Exit(0);
                }
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    totalMatch++;
                    int firstResult = int.Parse(Console.ReadLine());
                    int secondResult = int.Parse(Console.ReadLine());

                    diff = firstResult - secondResult;

                    if (firstResult>secondResult)
                    {
                        winCounts++;
                        result = "win";
                        Console.WriteLine($"Game {i} of tournament {name}: {result} with {diff} points.");
                    }
                    else
                    {
                        lossCounts++;
                        result = "lost";
                        Console.WriteLine($"Game {i} of tournament {name}: {result} with {Math.Abs(diff)} points.");
                    }
                }
            }
        }
    }
}
