﻿using System;

namespace _07.Repeat_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(command, count);

        }
        static void RepeatString(string command, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += command;
            }
            Console.WriteLine(result);
        }
    }
}
