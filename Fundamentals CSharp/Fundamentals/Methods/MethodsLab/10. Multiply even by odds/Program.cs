using System;

namespace _10._Multiply_even_by_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = multiplyEvenByOdds(number);
            Console.WriteLine(result);
        }
        static int multiplyEvenByOdds(int nums)
        {
            int result = SumOfEven(nums) * SumOfOdd(nums);
            return result;
        }
        static int SumOfEven(int currentNumber)
        {
            int sumOfEven = 0;
            int lastDigit = 0;
            while (currentNumber>0)
            {
                lastDigit = currentNumber % 10;

                if (lastDigit%2==0)
                {
                    sumOfEven += lastDigit;
                }
                currentNumber /= 10;

            }
            return sumOfEven;
        }
        static int SumOfOdd(int currentNumber)
        {
            int sumOfOdd = 0;
            int lastDigit = 0;

            while (currentNumber>0)
            {
                lastDigit = currentNumber % 10;

                if (lastDigit%2!=0)
                {
                    sumOfOdd += lastDigit;
                }
                currentNumber /= 10;
            }
            return sumOfOdd;
        }
       
    }
}
