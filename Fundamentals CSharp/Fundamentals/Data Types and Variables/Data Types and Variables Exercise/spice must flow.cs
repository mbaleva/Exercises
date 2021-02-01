using System;
using System.Net.Http.Headers;

namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            double spice = 0;
            double copy = 0;
            double eatedSpice = 0;
            int counter = 0;

            while (true)
            {
                if (start < 100)
                {
                    if (26<=eatedSpice)
                    {
                        eatedSpice -= 26;
                    }
                    Console.WriteLine($"{counter}\n{eatedSpice}");
                    break;
                }
                copy = start;
                start -= 10;
                copy -= 26;
                eatedSpice += copy;
                counter++;
            }
        }
    }
}