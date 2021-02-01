using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int l = 1; l <= i; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = n-1; i >=1 ; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int l = 1; l <= i; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
