using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int emptySpace = (n - 1) / 2;
            int stars = n - emptySpace;

            for (int i = 1; i <= (n-1)/2; i++)
            {
                Console.Write(new string('-', emptySpace));
                Console.Write("*");
                int mid = n - 2 * emptySpace - 2;

                if (mid>=0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', emptySpace));
                emptySpace--;
            }
            for (int i = n/2; i <n; i++)
            {
                Console.Write(new string('-', emptySpace));
                Console.Write("*");
                int mid = n - 2 * emptySpace - 2;

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', emptySpace));
                emptySpace++;
            }
        }
    }
}
