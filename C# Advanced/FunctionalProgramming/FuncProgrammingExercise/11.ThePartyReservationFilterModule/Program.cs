using System;
using System.Linq;
using System.Collections.Generic;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;


            List<string> variable = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .ToList();

            List<string> filtered = new List<string>();

            while ((command = Console.ReadLine()) != "Print")
            {
                string[] splitted = command.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitted[0] == "Add filter")
                {
                    filtered.Add(splitted[1] + " " + splitted[2]);
                }
                else
                {
                    filtered.Remove(splitted[1] + " " + splitted[2]);
                }
            }
            foreach (var item in filtered)
            {
                string[] commands = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                switch (commands[0])
                {
                    case "Starts":
                        variable = variable.Where(x => !x.StartsWith(commands[2])).ToList();
                        break;
                    case "Ends":
                        variable = variable.Where(x => !x.EndsWith(commands[2])).ToList();
                        break;
                    case "Length":
                        variable = variable.Where(x => x.Length != int.Parse(commands[1])).ToList();
                        break;
                    case "Contains":
                        variable = variable.Where(x => !x.Contains(commands[1])).ToList();
                        break;


                }
            }
            if (variable.Count>0)
            {
                Console.WriteLine(string.Join(" ", variable));
            }
        }
    }
}
