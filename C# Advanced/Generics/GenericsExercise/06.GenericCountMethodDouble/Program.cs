using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> genericList = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double randomNum = double.Parse(Console.ReadLine());
                genericList.Add(randomNum);
            }
            double lastElement = double.Parse(Console.ReadLine());

            Console.WriteLine(Compare(genericList, lastElement));
        }
        public static int Compare<T>(List<T> list, T compareElement)
            where T : IComparable
        {
            int counter = 0;

            foreach (var item in list)
            {
                if (item.CompareTo(compareElement) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}