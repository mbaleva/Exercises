using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> clients = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();
                if (arr[0]=="register")
                {
                    if (clients.ContainsKey(arr[1])&&clients.ContainsValue(arr[2]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {arr[2]}");
                    }
                    else
                    {
                        clients.Add(arr[1], arr[2]);
                        Console.WriteLine($"{arr[1]} registered {arr[2]} successfully");
                    }
                }
                else
                {
                    if (!clients.ContainsKey(arr[1]))
                    {
                        Console.WriteLine($"ERROR: user {arr[1]} not found");
                    }
                    else
                    {
                        clients.Remove(arr[1]);
                        Console.WriteLine($"{arr[1]} unregistered successfully");
                    }
                }
            }
            foreach (var item in clients)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
