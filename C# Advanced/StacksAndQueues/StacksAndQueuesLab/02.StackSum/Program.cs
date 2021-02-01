using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();

            Stack<int> myStack = new Stack<int>(arr);

            string command = string.Empty;

            while ((command = Console.ReadLine().ToLower())!="end")
            {
                string[] cmd = command.Split();
                if (cmd[0]=="add")
                {
                    int firstNum = int.Parse(cmd[1]);
                    int secondNum = int.Parse(cmd[2]);

                    myStack.Push(firstNum);
                    myStack.Push(secondNum);
                }
                if (cmd[0]=="remove")
                {
                    int count = int.Parse(cmd[1]);
                    if (count<myStack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            myStack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {myStack.Sum()}");
        }
    }
}
