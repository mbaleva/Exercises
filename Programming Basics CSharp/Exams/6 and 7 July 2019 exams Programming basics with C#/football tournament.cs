using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            double matchCount = double.Parse(Console.ReadLine());

            double Wcount = 0;
            int Dcount = 0;
            int Lcount = 0;

            for (int i = 1; i <= matchCount; i++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    Wcount++;
                }
                else if (result == "D")
                {
                    Dcount++;
                }
                else if (result == "L")
                {
                    Lcount++;
                }
            }

            double Wpoints = Wcount * 3;
            double Dpoints = Dcount * 1;
            double totalPoints = Wpoints + Dpoints;
            double winsPercentage = (Wcount / matchCount) * 100;

            if (matchCount!=0)
            {
                Console.WriteLine($"{teamName} has won {totalPoints} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {Wcount}");
                Console.WriteLine($"## D: {Dcount}");
                Console.WriteLine($"## L: {Lcount}");
                Console.WriteLine($"Win rate: {winsPercentage:F2}%");
            }
            else
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }
        }
    }
}

