using System;
using System.Linq;



namespace _03.Fibbonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[50];


            array[0] = 1;
            array[1] = 1;

            if (n>2)
            {
                for (int i = 2; i < n; i++)
                {
                    array[i] = array[i - 1] + array[i - 2];

                }
            }

            Console.WriteLine(array[n-1]);
        }
    }
}
