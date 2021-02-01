using System;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string cmd = string.Empty;

            while ((cmd = Console.ReadLine())!="END")
            {
                

                if (cmd.Contains("Push"))
                {
                    string[] Push = cmd.Split("Push", StringSplitOptions.RemoveEmptyEntries);
                    string[] splitted = Push[0].Split(", ");

                    stack.Push(splitted);
                }
                if (cmd.Contains("Pop"))
                {
                    if (stack.items.Count == 0)
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                       stack.Pop();
                    }
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
