using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double redCounter = 0;
            double orangeCounter = 0;
            double blueCounter = 0;
            double greenCounter = 0;
            string maxColor = string.Empty;

            double max = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    redCounter++;
                }
                else if (color == "orange")
                {
                    orangeCounter++;
                }
                else if (color == "blue")
                {
                    blueCounter++;
                }
                else if (color=="green")
                {
                    greenCounter++;
                }
               
            }
            if (redCounter>max)
            {
                max = redCounter;
                maxColor = "red";
            }
            if (orangeCounter > max)
            {
                max = orangeCounter;
                maxColor = "orange";

            }
            if (blueCounter > max)
            {
                max = blueCounter;
                maxColor = "blue";

            }
            if (greenCounter > max)
            {
                max = greenCounter;
                maxColor = "green";

            }
            Console.WriteLine($"Red eggs: {redCounter}");
            Console.WriteLine($"Orange eggs: {orangeCounter}");
            Console.WriteLine($"Blue eggs: {blueCounter}");
            Console.WriteLine($"Green eggs: {greenCounter}");
            Console.WriteLine($"Max eggs: {max} -> {maxColor}");

        }
    }
}
