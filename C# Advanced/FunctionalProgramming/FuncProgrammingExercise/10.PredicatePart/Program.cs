using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.PredicatePart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Party!")
            {
                var splitted = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                var something = GetPredicate(splitted[1], splitted[2]);

                if (splitted[0] == "Remove")
                {
                    input.RemoveAll(something);
                }
                else
                {
                    var all = input.FindAll(something);

                    if (all.Count>0)
                    {
                        int index = input.FindIndex(something);
                        input.InsertRange(index, all);
                    }
                }
            }
            if (input.Count>0)
            {
                Console.WriteLine($"{string.Join(", ", input)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static Predicate<string> GetPredicate(string commandType, string arg)
        {
            switch (commandType)
            {
                case "StartsWith":
                    return (name) => name.StartsWith(arg);
                case "EndsWith":
                    return (name) => name.EndsWith(arg);
                case "Length":
                    return (name) => name.Length == int.Parse(arg);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
