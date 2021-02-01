using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = 0;
            double countForFilm = 0;
            double countStandard = 0;
            double countStudent = 0;
            double countKid = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command=="Finish")
                {
                    break;
                }
                double capacity = double.Parse(Console.ReadLine());
                
                for (int i = 1; i <= capacity; i++)
                {
                    string filmName = Console.ReadLine();

                    if (filmName=="End")
                    {
                        break;
                    }

                    if (filmName=="standard")
                    {
                        countStandard++;
                    }
                    else if (filmName=="student")
                    {
                        countStudent++;
                    }
                    else if (filmName=="kid")
                    {
                        countKid++;
                    }
                    countForFilm++;
                    count++;


                }

                double isFullRoom = (countForFilm / capacity) * 100;
                Console.WriteLine($"{command} - {isFullRoom:F2}% full.");
                countForFilm = 0;
            }
            double standardPercentage = (countStandard / count) * 100;
            double studentPercentage = (countStudent / count) * 100;
            double kidPercentage = (countKid / count) * 100;
          
            Console.WriteLine($"Total tickets: {count}");
            Console.WriteLine($"{studentPercentage:F2}% student tickets.");
            Console.WriteLine($"{standardPercentage:F2}% standard tickets.");
            Console.WriteLine($"{kidPercentage:F2}% kids tickets.");
        }
    }
}