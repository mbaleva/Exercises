using System;
using System.Net.Http.Headers;

namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal max = decimal.MinValue;
            decimal total = 0;
            string maxKeg = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                total = 3.14M * (radius*radius) * height;

                if (total>max)
                {
                    max = total;
                    maxKeg = model;
                }
            }
            Console.WriteLine($"{maxKeg}");
        }
    }
}