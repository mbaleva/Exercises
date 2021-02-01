using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();


            Dictionary<string, List<string>> gosho = new Dictionary<string, List<string>>();

            while (command!="End")
            {
                string[] arr = command.Split(" -> ");

                string companyName = arr[0];
                string employeeID = arr[1];

                if (!gosho.ContainsKey(companyName))
                {
                    gosho.Add(companyName, new List<string>());

                }

                if (!gosho[companyName].Contains(employeeID))
                {
                    gosho[companyName].Add(employeeID);
                }
                command = Console.ReadLine();
            }

            foreach (var item in gosho.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var pesho in item.Value)
                {
                    Console.WriteLine($"-- {pesho}");
                }
            }
        }
    }
}
