using System;

namespace _08._Factorial_division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double division = result(firstNum, secondNum);

            Console.WriteLine($"{division:F2}");
        }
        static double factorialForFirstNum(double firstNum)
        {
            double firstNumber = firstNum;
            if (firstNum==0)
            {
                return 1;
            }
            for (double i = firstNum-1; i >0; i--)
            {
                firstNumber *= i;
            }
            return firstNumber;
        }
        static double factorialForSecondNum(double secondNum)
        {
            double secondNumber = secondNum;
            if (secondNum==0)
            {
                return 1;
            }
            for (double i = secondNum-1; i >0; i--)
            {
                secondNumber *= i;
            }
            return secondNumber;
        }
        static double result(double firstNum, double secondNum)
        {
            double division = factorialForFirstNum(firstNum) / factorialForSecondNum(secondNum);
            return division;
        }
    }
}
