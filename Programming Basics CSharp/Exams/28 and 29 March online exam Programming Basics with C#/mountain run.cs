using System;


namespace NestedLoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordsSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeWithoutSlower = meters * timeForOneMeter;
            double slower =Math.Floor(meters / 50);
            double slower1 = slower * 30;
            double totalTime = timeWithoutSlower + slower1;

            if (recordsSeconds<=totalTime)
            {
                double neededTime = totalTime - recordsSeconds;
                Console.WriteLine($"No! He was {neededTime:F2} seconds slower.");
            }
            else
            {
                double neededTime = recordsSeconds - totalTime;
                Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
            }
        }
    }
}
