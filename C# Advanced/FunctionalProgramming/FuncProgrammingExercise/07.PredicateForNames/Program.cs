using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());

            string[] variable = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            variable = variable.Where(x => x.Length <= length).ToArray();
            Console.WriteLine(string.Join("\n", variable));
        }
    }
}
