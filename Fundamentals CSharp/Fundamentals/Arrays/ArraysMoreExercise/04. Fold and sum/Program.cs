using System;
using System.Linq;

namespace _04._Fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = array.Length / 4;
            int[] newArr = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                newArr[i] = array[k - (i + 1)] + array[k + i];
                newArr[newArr.Length - 1 - i] = array[newArr.Length - 1 - i + k] + array[(newArr.Length - 1 - i) + (k + 2 * i + 1)];
            }
            Console.WriteLine(string.Join(" ", newArr));

        }
    }
}
