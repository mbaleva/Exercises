using System;
using System.Linq;

namespace _05._Longest_increasing_subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] lis;
            int[] len = new int[array.Length];
            int[] prev = new int[array.Length];
            int maxLength = int.MinValue;
            int lastIndexOfTheArray = -1;

            for (int i = 0; i < array.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j; 
                    }

                }
                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndexOfTheArray = i;
                }
            }
            lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = array[lastIndexOfTheArray];
                lastIndexOfTheArray = prev[lastIndexOfTheArray];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
