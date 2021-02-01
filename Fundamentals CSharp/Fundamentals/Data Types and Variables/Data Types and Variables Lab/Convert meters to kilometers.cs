using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());

            decimal kilometres = input * 0.001M;

            Console.WriteLine($"{kilometres:F2}");
        }
    }
}
