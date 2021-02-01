using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            string commands = string.Empty;
            while ((commands = Console.ReadLine())!="PARTY")
            {
                set.Add(commands);
            }

            string input = string.Empty;
            while ((input=Console.ReadLine())!="END")
            {
                if (set.Contains(input))
                {
                    set.Remove(input);
                }
            }

            Console.WriteLine(set.Count);

            foreach (var item in set)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in set)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
