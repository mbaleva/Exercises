using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> brum = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] currentName = Console.ReadLine().Split().ToArray();

                brum.Add(currentName[0], int.Parse(currentName[1]));
            }
             int counter = 0;
            foreach (var item in brum.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
                counter++;

                if (counter==1)
                {
                    break;
                }
            }
        }
    }
    
}
