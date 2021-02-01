using System;

namespace brum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double bakcCount = 0;
            double chestCount = 0;
            double legsCount = 0;
            double absCount = 0;
            double trainingCount = 0;
            double buyingCount = 0;
            double proteinShakeCount = 0;
            double proteinBarCount = 0;

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();

                if (command == "Back")
                {
                    bakcCount++;
                    trainingCount++;
                }
                else if (command == "Chest")
                {
                    chestCount++;
                    trainingCount++;
                }
                else if (command == "Legs")
                {
                    legsCount++;
                    trainingCount++;
                }
                else if (command == "Abs")
                {
                    absCount++;
                    trainingCount++;
                }
                else if (command == "Protein shake")
                {
                    proteinShakeCount++;
                    buyingCount++;
                }
                else if (command == "Protein bar")
                {
                    proteinBarCount++;
                    buyingCount++; 
                }
            }
            double trainPercentage = (trainingCount / n) * 100;
            double buyPercentage = (buyingCount / n) * 100;

            Console.WriteLine($"{bakcCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legsCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{proteinShakeCount} - protein shake");
            Console.WriteLine($"{proteinBarCount} - protein bar");
            Console.WriteLine($"{trainPercentage:F2}% - work out");
            Console.WriteLine($"{buyPercentage:F2}% - protein");
        }
    }
}
