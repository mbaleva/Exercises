using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                array[i] = currentNumber;
                sum += currentNumber;
            }
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(sum);
        }
    }
}
