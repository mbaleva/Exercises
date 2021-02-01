using System;

namespace _10._Top_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            topInteger(n);
        }
        static void topInteger(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (isSumOfNumsIsDivisibleBy8(i) && IsHaveOnlyOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsHaveOnlyOneOddDigit(int num)
        {
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }

                num /= 10;
            }
            return false;
        }
        static bool isSumOfNumsIsDivisibleBy8(int num)
        {
            int sumOfDigits = 0;
            while (num > 0)
            {
                sumOfDigits += num % 10;
                num /= 10;
            }
            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            return false;
        }

    }
}
