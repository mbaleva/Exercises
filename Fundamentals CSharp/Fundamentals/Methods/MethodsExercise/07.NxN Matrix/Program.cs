using System;

namespace _07.NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        static void oneLine(int n)
        {
            for (int i = 1; i <=n ; i++)
            {
                Console.Write(n + " ");
            }
        }
        static void Matrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                oneLine(n);
                Console.WriteLine();
            }
        }
    }
}
