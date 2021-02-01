using System;
using System.Linq;

namespace _05._Sum_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];

                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
