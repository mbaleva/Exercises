using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Word_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().Where(meow=>meow.Length%2==0).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
