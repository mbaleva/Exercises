using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> genericList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                genericList.Add(input);
            }
            string lastElement = Console.ReadLine();

            Console.WriteLine(Compare(genericList,lastElement));
        }
        public static int Compare<T>(List<T> list, T element)
            where T: IComparable<T>
        {
            int counter = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element)>0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
