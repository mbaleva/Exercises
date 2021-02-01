using System;

namespace brum
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            double points = 0.00; 
            double totalPoints = 301;
            bool flag = true;
            int successShots = 0;
            int failsShots = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Retire")
                {

                    break;
                }
                int currentPoints = int.Parse(Console.ReadLine());

                if (command == "Single")
                {
                    currentPoints *= 1;

                    if (currentPoints>totalPoints)
                    {
                        failsShots++;
                    }
                    else
                    {
                        successShots++;
                        totalPoints -= currentPoints;
                    }
                }
                if (command=="Double")
                {
                    currentPoints *= 2;
                    if (currentPoints > totalPoints)
                    {
                        failsShots++;
                    }
                    else
                    {
                        successShots++;
                        totalPoints -= currentPoints;
                    }
                }
                if (command == "Triple")
                {
                    currentPoints *= 3;
                    if (currentPoints > totalPoints)
                    {
                        failsShots++;
                    }
                    else
                    {
                        successShots++;
                        totalPoints -= currentPoints;
                    }
                }
                if (totalPoints==0)
                {
                    break;
                }

                
            }
            if (totalPoints==0)
            {
                Console.WriteLine($"{playerName} won the leg with {successShots} shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} retired after {failsShots} unsuccessful shots.");
            }
        }
    }
}
