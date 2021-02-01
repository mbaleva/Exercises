using System;
using System.Collections.Generic;

namespace _04._List_of_products
{
    class Program
    {
        static void Main(string[] args)
        {
            int countProducts = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < countProducts; i++)
            {
                string currentProduct = Console.ReadLine();
                list.Add(currentProduct);
            }
            list.Sort();
            for (int i = 0; i < countProducts; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }
        }
    }
}
