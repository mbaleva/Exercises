using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            HashSet<string> set = new HashSet<string>();

            while ((command=Console.ReadLine())!="END")
            {
                var splitted = command.Split(", ");

                if (splitted[0]=="IN")
                {
                    set.Add(splitted[1]);
                }
                if (splitted[0]=="OUT")
                {
                    set.Remove(splitted[1]);
                }
            }
            if (set.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
