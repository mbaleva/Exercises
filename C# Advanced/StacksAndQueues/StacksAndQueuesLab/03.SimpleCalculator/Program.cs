using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] whyThisDoesntWork = input.Split(' ');

            Stack<string> stack = new Stack<string>(whyThisDoesntWork.Reverse());

            while (stack.Count>1)
            {
                int firstNum = int.Parse(stack.Pop());
                string operand = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                switch (operand)
                {
                    case "+":
                        stack.Push((firstNum + secondNum).ToString());
                        break;
                    case "-":
                        stack.Push((firstNum - secondNum).ToString());
                        break;
                }

            }
            Console.WriteLine(stack.Pop());
        }
    }
}
