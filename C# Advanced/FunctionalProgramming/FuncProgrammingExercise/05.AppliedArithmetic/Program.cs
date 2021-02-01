using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.AppliedArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> variable = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            string command = string.Empty;

            while ((command=Console.ReadLine())!="end")
            {
                switch (command)
                {
                    case "add":
                       variable =  variable.Select(x => x + 1).ToList();
                        break;
                    case "multiply":
                      variable =  variable.Select(x => x * 2).ToList();
                        break;
                    case "subtract":
                        variable = variable.Select(x => x - 1).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", variable));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
