using System;
using System.Linq;

namespace ArraysMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
