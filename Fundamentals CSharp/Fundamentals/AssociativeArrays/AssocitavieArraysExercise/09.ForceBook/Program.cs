using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string,string> dict = new Dictionary<string, string>();


            while (command!= "Lumpawaroo")
            {
                string[] arr = command
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();

                if (arr.Contains("|"))
                {
                    string[] gosho = arr.ToArray();

                    string side = command.Split(" | ", 2)[0];
                    string user = command.Split(" | ", 2)[1];

                    if (!dict.ContainsKey(user))
                    {
                        dict.Add(user,side);
                    }

                }

                if (arr.Contains("->"))
                {

                    string side = command.Split(" -> ", 2)[1];
                    string user = command.Split(" -> ", 2)[0];

                    if (dict.ContainsKey(user))
                    {
                        dict[user] = side;
                    }
                    else
                    {
                        dict.Add(user, side);
                    }
                    Console.WriteLine($"{user} joins the {side} side!");
                }
                command = Console.ReadLine();
            }
            foreach (var item in dict.GroupBy(x => x.Value)
                                .OrderByDescending(x => x.Count())
                                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Count()}");

                foreach (var gosho in item.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"! {gosho.Key}");
                }
            }
        }
    }
}

