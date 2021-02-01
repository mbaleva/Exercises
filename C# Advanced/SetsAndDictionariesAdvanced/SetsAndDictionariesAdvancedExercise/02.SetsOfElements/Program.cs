using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = arr[0] + arr[1];


            List<int>  pesho= new List<int>();

            HashSet<int> one = new HashSet<int>();
            HashSet<int> two = new HashSet<int>();

            for (int i = 0; i < arr[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                one.Add(num);
                pesho.Add(num);
            }

            for (int i = 0; i < arr[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                two.Add(num);
                pesho.Add(num);
            }

            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < pesho.Count; i++)
            {
                if (one.Contains(pesho[i])&&two.Contains(pesho[i]))
                {
                    result.Add(pesho[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
