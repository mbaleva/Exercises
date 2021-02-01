using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= n*n; i++)
            {
                counter++;
                Console.Write("*");
                if (counter==n)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
        }
    }
}