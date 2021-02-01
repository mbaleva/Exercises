using System;
using System.Numerics;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[] result = TribonacciNumbers(n);

            Console.WriteLine(String.Join(' ', result));
        }
        private static BigInteger[] TribonacciNumbers(int n)
        {
            BigInteger[] result = new BigInteger[n];

            if (n == 1)
            {
                result[0] = 1;
            }
            else if (n == 2)
            {
                result[0] = 1;
                result[1] = 1;
            }
            else if (n == 3)
            {
                result[0] = 1;
                result[1] = 1;
                result[2] = 2;
            }
            else
            {
                result[0] = 1;
                result[1] = 1;
                result[2] = 2;

                for (int i = 3; i < n; i++)
                {
                    BigInteger currNum = result[i - 3] + result[i - 2] + result[i - 1];
                    result[i] = currNum;
                }
            }

            return result;
        }
    }
}
