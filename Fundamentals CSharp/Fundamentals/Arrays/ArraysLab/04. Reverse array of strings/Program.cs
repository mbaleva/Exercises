using System;
using System.Linq;

namespace _04._Reverse_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            for (int i = 0; i < array.Length/2; i++)
            {
                string temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
