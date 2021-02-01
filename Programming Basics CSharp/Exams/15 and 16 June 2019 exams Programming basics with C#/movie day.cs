using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededTime = int.Parse(Console.ReadLine());
            int countScenes = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            double preparations = neededTime * 0.15;
            double neeededTime = countScenes * time;
            double totalTime = preparations + neeededTime;

            double diff = totalTime - neededTime;

            if (totalTime>neededTime)
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Ceiling(diff)} minutes.");
            }
            else
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Ceiling(Math.Abs(diff))} minutes left!");
            }
        }
    }
}