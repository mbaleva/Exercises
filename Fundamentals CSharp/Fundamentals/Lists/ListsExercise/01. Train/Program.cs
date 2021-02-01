using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "end")
                {
                    Console.WriteLine(String.Join(" ",input));
                    break;
                }
                if (command[0] == "Add")
                {
                    int num = int.Parse(command[1]);
                    input.Add(num);
                    continue;
                }
                int passengers = int.Parse(command[0]);

                for (int i = 0; i < input.Count; i++)
                {
                    if (passengers+input[i]<=capacity)
                    {
                        input[i] += passengers;
                        break;
                    }
                }
            }
        }

    }
}
