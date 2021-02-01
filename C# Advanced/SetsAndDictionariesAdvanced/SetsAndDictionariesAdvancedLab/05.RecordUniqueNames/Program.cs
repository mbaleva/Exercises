﻿using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> meow = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                meow.Add(name);
            }

            foreach (var item in meow)
            {
                Console.WriteLine(item);
            }
        }
    }
}
