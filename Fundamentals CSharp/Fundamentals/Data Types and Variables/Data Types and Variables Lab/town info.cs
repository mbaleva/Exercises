using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string  a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {a} has population of {b} and area {c} square km.");
        }
    }
}
