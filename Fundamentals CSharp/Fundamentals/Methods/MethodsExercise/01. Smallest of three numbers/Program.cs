using System;

namespace _01._Smallest_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double threeNum = double.Parse(Console.ReadLine());

            Console.WriteLine(smallestNum(firstNum,secondNum,threeNum));
        }
        static double smallestNum(double a, double b, double c)
        {
            double minNum = double.MaxValue;

            if (a<=b&&a<=c)
            {
                minNum = a;
            }
            else if (b<=a&&b<=c)
            {
                minNum = b;
            }
            else
            {
                minNum = c;
            }
            return minNum;
        }
    }
}
