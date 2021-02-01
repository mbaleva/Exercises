using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double trainsPrice = n * 0.6;
            double teamPrice = trainsPrice * 0.8;
            double ball = teamPrice * 0.25;
            double accsesories = 0.2 * ball;

            double totalPrice = n+trainsPrice + teamPrice + ball + accsesories;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
