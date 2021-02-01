using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!output.ContainsKey(command))
                {
                    output.Add(command, quantity);
                }
                //Ако съдържа командата трябва да се добави само стойността
                else
                {
                    output[command] += quantity;
                }
                
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
