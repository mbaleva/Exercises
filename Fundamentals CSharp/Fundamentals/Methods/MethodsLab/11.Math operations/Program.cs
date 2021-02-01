using System;

namespace _11.Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operand = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Result(firstNum, operand, secondNum));
        }
        static int Result(int firstNum, string operand, int secondNum)
        {
            int result = 0;
            if (operand == "+")
            {
                result = firstNum + secondNum;
            }
            else if (operand == "-")
            {
                result = firstNum - secondNum;
            }
            else if (operand == "*")
            {
                result = firstNum * secondNum;
            }
            else if (operand == "/")
            {
                result = firstNum / secondNum;
            }
            return result;
        }
    }
}
