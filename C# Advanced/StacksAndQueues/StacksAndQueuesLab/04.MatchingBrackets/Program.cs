using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    stack.Push(i);
                }
                if (input[i]==')')
                {
                    int openingBracket = stack.Pop();
                    result = input.Substring(openingBracket, i - openingBracket + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
