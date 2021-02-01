using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_manipulation_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (command[0]=="end")
                {
                    break;
                }
                
                if (command[0] == "Add")
                {
                  
                    input.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    int num = int.Parse(command[1]);
                    input.Remove(int.Parse(command[1]));
                   
                }
                else if (command[0] == "RemoveAt")
                {
                    int num = int.Parse(command[1]);
                    input.RemoveAt(int.Parse(command[1]));
                  
                }
                else if (command[0] == "Insert")
                {
                    int num = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    input.Insert(index, num);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
        
        
    }
}
