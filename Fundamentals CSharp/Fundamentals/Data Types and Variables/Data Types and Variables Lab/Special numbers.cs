using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int nums = 1; nums <= n; nums++)
            {
                double sum = 0;
                int digits = nums;
                while (digits > 0)
                {
                    sum += digits%10;
                    digits /= 10;
                }
                bool isSpecial = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine($"{nums} -> {isSpecial}");
                sum = 0;
            }
        }
    }
}
