using System;
using System.Linq;

namespace _06._Even_odd_substraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int sumForEven = 0;
            int sumForOdd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];

                if (currentNumber % 2 == 0)
                {
                    sumForEven += currentNumber;
                }
                else if (currentNumber % 2 != 0)
                {
                    sumForOdd += currentNumber;
                }
            }
            int diff = sumForEven - sumForOdd;
            Console.WriteLine(diff);
        }
    }
}
