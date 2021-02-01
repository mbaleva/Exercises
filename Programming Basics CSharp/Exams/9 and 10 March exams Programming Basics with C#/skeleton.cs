using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double secondsPer100Meters = double.Parse(Console.ReadLine());

            double totalSeconds = minutes * 60 + seconds;
            double slower =length / 120;
            double totalSlower = slower * 2.5;
            double totalTime = (length / 100) * secondsPer100Meters - totalSlower;

            if (totalTime<=totalSeconds)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalTime:F3}.");
            }
            else
            {
                double diff = totalTime - totalSeconds;
                Console.WriteLine($"No, Marin failed! He was {diff:F3} second slower.");
            }

        }
    }
}
