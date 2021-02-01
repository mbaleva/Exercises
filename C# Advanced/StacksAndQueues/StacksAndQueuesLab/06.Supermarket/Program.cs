using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            Queue<string> myQueue = new Queue<string>();

            while ((command=Console.ReadLine())!="End")
            {
                if (command=="Paid")
                {
                    while (myQueue.Count>0)
                    {
                        Console.WriteLine(myQueue.Dequeue());
                    }
                }
                else
                {
                    myQueue.Enqueue(command);
                }
            }
            Console.WriteLine($"{myQueue.Count} people remaining.");
        }
    }
}
