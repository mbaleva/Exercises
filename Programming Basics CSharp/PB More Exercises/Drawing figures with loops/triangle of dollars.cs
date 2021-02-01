using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {

                    Console.Write("$ ");
                    counter++;
                    if (counter == rows)
                    {
                        Console.WriteLine();
                        counter = 0;

                    }
                }
            }
        }
    }
}
