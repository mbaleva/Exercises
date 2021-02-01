using System;
using System.Net.Http.Headers;

namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int startingNumber = powerN;
            int counter = 0;
            bool isPossible = false;
            while (powerN!=0)
            {
                if (powerN<distanceM)
                {
                    break;
                }
                powerN -= distanceM;
                counter++;

                if (powerN == startingNumber * 0.5&&powerN!=0)
                {
                    if (Y > 0)
                    {


                        powerN /= Y;
                        if (powerN > 0 && powerN != 0)
                        {
                            isPossible = true;
                        }
                    }
                }
            }
            Console.WriteLine($"{powerN}\n{counter}");
        }
    }
}