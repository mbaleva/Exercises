using System;
using System.Net.Http.Headers;

namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                sum += currentNumber;

                if (sum>255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    sum -= currentNumber;
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}