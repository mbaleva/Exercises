using System;
using System.Collections.Generic;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<char> stack = new Stack<char>();


            bool result = true;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (stack.Count==0||stack.Pop()!=input[i])
                        {
                            result = false;
                        }
                        break;
                }
                if (!result)
                {
                    break;
                }
            }
            if (result==true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
