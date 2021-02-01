using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodesPerSeason = int.Parse(Console.ReadLine());
            int oneEpisodeTime = int.Parse(Console.ReadLine());

            double advertisment = oneEpisodeTime * 1.2;
            double extraTime = seasons * 10;

            double totalTime = advertisment * episodesPerSeason * seasons + extraTime;

            Console.WriteLine($"Total time needed to watch the {serialName} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}