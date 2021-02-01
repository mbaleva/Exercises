using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointForAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double points = pointForAcademy;

            bool flag = false;

            for (int i = 1; i <= n; i++)
            {
                string juryName = Console.ReadLine();
                double pointsForJury = double.Parse(Console.ReadLine());

                double pointsPerOneIteration = ((juryName.Length * pointsForJury) / 2);
                points = points + pointsPerOneIteration;

                if (points>=1250.5)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:F1} more!");
            }
        }
    }
}