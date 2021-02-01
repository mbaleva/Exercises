using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star1 = 2;
            int star2 = 1;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"{new string('-', ((n - 2) / 2)-i)}{new string('*', star1)}" +
                        $"{new string('-', ((n - 2) / 2) - i)}");
                }
                else
                {
                    Console.WriteLine($"{new string('-', ((n - 1) / 2)-i)}{new string('*', star2)}" +
                        $"{new string('-', ((n - 1) / 2) - i)}");
                }
                star1 += 2;
                star2 += 2;
            }
            for (int j = 1; j <= n / 2; j++)
            {
                Console.WriteLine($"|{new string('*', n - 2)}|");
            }
        }
    }
}
