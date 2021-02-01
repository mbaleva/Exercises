using System;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split("\\");

            string[] pesho = arr[arr.Length-1].Split('.').ToArray();

            Console.WriteLine($"File name: {pesho[0]}");
            Console.WriteLine($"File extension: {pesho[1]}");

        }
    }
}
