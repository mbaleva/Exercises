using System;

namespace _05._Add_and_substract
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            Console.WriteLine(Add(firstNum,secondNum,thirdNum));
        }
        static double Add(double firstNum, double secondNum,double thirdNum)
        {
            double sum = firstNum + secondNum;
            double result = sum - thirdNum;
            return result;
        }
        
    }
}
