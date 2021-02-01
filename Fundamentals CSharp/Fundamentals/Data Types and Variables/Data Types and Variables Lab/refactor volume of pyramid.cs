using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double volume = double.Parse(Console.ReadLine());

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            double v = (length * width * volume)/3;
            Console.Write($"Pyramid Volume: {v:F2}");

        }
    }
}
