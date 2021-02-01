using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int neededHeight = n - 30;
            int counter = 0;
            int totalCount = 0;

            int heightChageSum = n;

            int jump = 0;
            while (true)
            {
                jump = int.Parse(Console.ReadLine());
                totalCount++;
                if (jump > neededHeight)
                {
                    if (neededHeight >= heightChageSum)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {n}cm after {totalCount} jumps.");
                        break;
                    }
                    neededHeight += 5;
                    counter = 0;
                }


                else if (jump <= neededHeight)
                {
                    counter++;
                }

                if (counter == 3)
                {
                    Console.WriteLine($"Tihomir failed at {neededHeight}cm after {totalCount} jumps.");
                    return;
                }


            }
        }
    }
}