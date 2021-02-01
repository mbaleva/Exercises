using System;
using System.Numerics;


namespace ConditionalExercise
{
    class Program
    {
        static void Main()
        {
            int integer;
            double floatingPoint;
            char characters;
            bool boolean;
            string strings;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (int.TryParse(command, out integer))
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else  if(double.TryParse(command, out floatingPoint))
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (char.TryParse(command, out characters))
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (bool.TryParse(command, out boolean))
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }
            }
        }
    }
}