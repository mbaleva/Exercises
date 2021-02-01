using System;
using System.Linq;

namespace _04._Array_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int temp = array[0];
                int[] newArray = new int[array.Length];

                for (int j = 1; j < array.Length; j++)
                {

                    newArray[j - 1] = array[j];


                }
                newArray[newArray.Length - 1] = temp;
                array = newArray;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
