using System;

namespace _08.MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentNumber = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Pow(currentNumber, pow);
        }
        static void Pow(double num, double pow)
        {
            double result = num;
            for (int i = 1; i < pow; i++)
            {
                result *= num;

            }
            Console.WriteLine(result);
        }
    }
}
