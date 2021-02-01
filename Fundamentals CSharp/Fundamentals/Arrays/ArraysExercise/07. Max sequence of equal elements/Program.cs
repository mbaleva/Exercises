using System;
using System.Linq;

namespace _07._Max_sequence_of_equal_elements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;
            int max = 0;
            int start = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;

                    if (count>max)
                    {
                        start = i - count;
                        max = count;
                    }
                }
                else
                {
                    count = 0;
                }
                
            }
            for (int i = start+1; i <=start+max+1; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
