using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss_trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        

            int length = numbers.Count;

            for (int i = 0; i < length/2; i++)
            {
                numbers[i]+=numbers[numbers.Count - 1];
                
                numbers.RemoveAt(numbers.Count - 1);
                
            }
            // 1 2 3 4
           
           
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
