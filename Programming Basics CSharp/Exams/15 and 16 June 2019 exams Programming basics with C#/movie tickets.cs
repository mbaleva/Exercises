using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = a1; i <= a2-1; i++)
            {
                char a = (char)i;
                int symbol = (int)a;
                for (int j = 1; j <= n-1; j++)
                {
                    for (int k = 1; k <= n/2-1; k++)
                    {
                        int evenOrOdd = j + k + symbol;
                        if (evenOrOdd%2!=0)
                        {
                            if (symbol%2!=0)
                            {
                                Console.WriteLine($"{a}-{j}{k}{symbol}");
                            }
                        }
                        
                    }
                }


            }
        }
    }
}