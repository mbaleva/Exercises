using System;
using System.Linq;

namespace _08._Condense_array_to_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


            while (numbers.Length != 1)
            {
                int[] newArray = new int[numbers.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = numbers[i] + numbers[i + 1];

                }
                numbers = newArray;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
