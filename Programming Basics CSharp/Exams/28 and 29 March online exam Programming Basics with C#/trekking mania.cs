using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGroups = int.Parse(Console.ReadLine());
            double totalPeople = 0.00;
            double mountain1 = 0.00;
            double mountain2 = 0.00;
            double mountain3 = 0.00;
            double mountain4 = 0.00;
            double mountain5 = 0.00;
            for (int i = 1; i <= countGroups; i++)
            {
                int currentGroup = int.Parse(Console.ReadLine());

                totalPeople += currentGroup;

                if (currentGroup<=5)
                {
                    mountain1 += currentGroup;
                }
                else if (currentGroup>=6&&currentGroup<=12)
                {
                    mountain2 += currentGroup;
                }
                else if (currentGroup >= 13 && currentGroup <= 25)
                {
                    mountain3 += currentGroup;
                }
                else if (currentGroup >= 26 && currentGroup <= 40)
                {
                    mountain4 += currentGroup;
                }
                else if (currentGroup>=41)
                {
                    mountain5 += currentGroup;
                }
            }
            double mountain1Percentage = (mountain1 / totalPeople) * 100;
            double mountain2Percentage = (mountain2 / totalPeople) * 100;
            double mountain3Percentage = (mountain3 / totalPeople) * 100;
            double mountain4Percentage = (mountain4 / totalPeople) * 100;
            double mountain5Percentage = (mountain5 / totalPeople) * 100;

            Console.WriteLine($"{mountain1Percentage:F2}%");
            Console.WriteLine($"{mountain2Percentage:F2}%");
            Console.WriteLine($"{mountain3Percentage:F2}%");
            Console.WriteLine($"{mountain4Percentage:F2}%");
            Console.WriteLine($"{mountain5Percentage:F2}%");
        }
    }
}

