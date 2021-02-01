using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());


            }
            for (int k = 0; k <array.Length;  k++)
            {
                Console.Write(array[array.Length - k - 1] + " ");
            }
        }
    }
}
