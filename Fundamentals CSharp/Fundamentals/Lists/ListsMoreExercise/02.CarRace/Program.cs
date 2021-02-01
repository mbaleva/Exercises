using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToList();

            int middle = input.Count / 2;

            double leftCar = 0;
            double rightCar = 0;

            for (int i = 0; i < middle; i++)
            {
                if (input[i]==0)
                {
                    leftCar *= 0.8;
                }
                else
                {
                    leftCar += input[i];
                }
            }
            //1 2 3 4 5
            //0 1 2 3 4
            for (int i = input.Count-1; i > middle; i--)
            {
                if (input[i] == 0)
                {
                    rightCar *= 0.8;
                }
                else
                {
                    rightCar += input[i];
                }
            }
            if (leftCar>rightCar)
            {
                // Console.WriteLine($"The winner is left with total time: {leftCar}");
                Console.WriteLine($"The winner is right with total time: {rightCar}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {leftCar}");
            }
        }
    }
}
