using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_list
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0]=="end")
                {
                    break;
                }
                if (command[0] == "Delete")
                {
                    int num = int.Parse(command[1]);
                    input.RemoveAll(n => n == num);
                }
                if (command[0]=="Insert")
                {
                    int num = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    input.Insert(index, num);
                }
            }
            Console.WriteLine(String.Join(" ",input));
        }
    }
}
