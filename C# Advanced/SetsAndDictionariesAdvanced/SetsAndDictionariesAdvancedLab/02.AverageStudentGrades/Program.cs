using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> bum = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split().ToArray();

                string name = arr[0];
                decimal grade = decimal.Parse(arr[1]);

                if (!bum.ContainsKey(name))
                {
                    bum.Add(name, new List<decimal>());
                }
                bum[name].Add(grade);
            }

            foreach (var item in bum)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {item.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
