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
            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int currentNumber = (int)letter;
                sum += currentNumber;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}