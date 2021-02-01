using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVlogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> dict = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] splitted = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string vloggerName = splitted[0];


                if (splitted[1] == "joined")
                {
                    if (!dict.ContainsKey(vloggerName))
                    {
                        dict.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        dict[vloggerName].Add("followers", new SortedSet<string>());
                        dict[vloggerName].Add("following", new SortedSet<string>());
                    }
                }
                else
                {
                    string anotherVlogger = splitted[2];

                    if (vloggerName == anotherVlogger || !dict.ContainsKey(vloggerName) || !dict.ContainsKey(anotherVlogger))
                    {
                        continue;
                    }
                    Dictionary<string, SortedSet<string>> temp = dict[vloggerName];
                    dict[vloggerName]["following"].Add(anotherVlogger);
                    dict[anotherVlogger]["followers"].Add(vloggerName);
                }
            }
            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");


            int counter = 1;

            dict = dict.OrderByDescending(kvp => kvp.Value["followers"].Count)
                 .ThenBy(kvp => kvp.Value["following"].Count)
                 .ToDictionary(key => key.Key, value => value.Value);

            foreach ((string vlogger, Dictionary<string, SortedSet<string>> keyValuePairs) in dict)
            {
                Console.WriteLine($"{counter++}. {vlogger} : {keyValuePairs["followers"].Count} followers, {keyValuePairs["following"].Count} following");

                if (counter == 2)
                {
                    foreach (var item in keyValuePairs["followers"])
                    {
                        Console.WriteLine($"*  {item}");

                    }
                }
            }
        }
    }

}
