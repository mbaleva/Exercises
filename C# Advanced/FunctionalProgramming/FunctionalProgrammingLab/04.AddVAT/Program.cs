using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] arr = Console.ReadLine()
                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                          .Select(decimal.Parse)
                          .Select(x => x * 1.2m)
                          .ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine($"{item:F2}");
            }
        }
    }
}
