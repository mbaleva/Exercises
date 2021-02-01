using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queue = new Queue<string>(arr);

            while (queue.Count>0)
            {
                string command = Console.ReadLine();

                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    var song = command.Split("Add ");
                    if (!queue.Contains(song[1]))
                    {
                        queue.Enqueue(song[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{song[1]} is already contained!");
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
