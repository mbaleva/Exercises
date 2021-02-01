using System;

namespace SimpleOperationsAndMoreCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

                if (i==n)
                {
                    double averageSum = sum / n;
                    Console.WriteLine($"{averageSum:F2}");
                }
            }
            
        }
    }
}