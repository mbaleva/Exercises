using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int timePerOneEpisod = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime * 0.125;
            double time = breakTime * 0.25;
            double totaltime = breakTime - (lunchTime + time);

            double diff = totaltime - timePerOneEpisod;

            if (totaltime>=timePerOneEpisod)
            {
                Console.WriteLine($"You have enough time to watch {filmName} and left with {Math.Ceiling(diff)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {filmName}, you need {Math.Ceiling(Math.Abs(diff))} more minutes.");
            }
        }
    }
}