using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            Stack<string> myStack = new Stack<string>();
            myStack.Push(sb.ToString());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    sb = sb.Append(command[1]);
                    myStack.Push(sb.ToString());
                }
                else if (command[0] == "2")
                {
                    int count = int.Parse(command[1]);
                    sb.Remove(sb.Length - count, count);
                    myStack.Push(sb.ToString());
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(sb[index-1]);
                }
                else if (command[0] == "4")
                {
                    myStack.Pop();
                    sb = new StringBuilder();
                    sb.Append(myStack.Peek());
                }
            }
        }
    }
}
