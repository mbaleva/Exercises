using System;
using System.Linq;

namespace _02.KnightsOfHonour
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
              .Split();

            Action<string> printStrings = (x) => Console.WriteLine($"Sir {x}");

            strings.ToList().ForEach(x => printStrings(x));


        }
    }
}
