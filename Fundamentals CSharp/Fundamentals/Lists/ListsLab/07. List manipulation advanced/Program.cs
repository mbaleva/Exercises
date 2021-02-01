using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_manipulation_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            
            bool isHaveChanges = false;

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0]=="end")
                {
                    if (isHaveChanges)
                    {
                        Console.WriteLine(string.Join(" ",input));
                    }
                    break;
                }
                else if(command[0]=="Add")
                {
                    int numToAdd = int.Parse(command[1]);
                    input.Add(numToAdd);
                    isHaveChanges = true;
                }
                else if (command[0] == "Remove")
                {
                    int num = int.Parse(command[1]);
                    input.Remove(int.Parse(command[1]));
                    isHaveChanges = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    int num = int.Parse(command[1]);
                    input.RemoveAt(int.Parse(command[1]));
                    isHaveChanges = true;
                }
                else if (command[0] == "Insert")
                {
                    int num = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    input.Insert(index, num);
                    isHaveChanges = true;
                }
                else if (command[0]=="Contains")
                {
                    int isContainsNum = int.Parse(command[1]);

                    if (input.Contains(isContainsNum)==true)
                    {

                        Console.WriteLine("Yes");
                        
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                 
                }
                else if (command[0]=="PrintEven")
                {
                    List<int> newList = new List<int>();
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i]%2==0)
                        {
                            newList.Add(input[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ",newList));
                    newList.RemoveAll(n => n >= 0);
                    newList.RemoveAll(n => n == 0);
                    newList.RemoveAll(n => n < 0);
                }
                else if (command[0]=="PrintOdd")
                {
                    List<int> newList = new List<int>();
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i]%2!=0)
                        {
                            newList.Add(input[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ",newList));
                    newList.RemoveAll(n => n >= 0);
                    newList.RemoveAll(n => n == 0);
                    newList.RemoveAll(n => n < 0);
                }
                else if (command[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < input.Count; i++)
                    {
                        sum += input[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (command[0] == "Filter")
                {
                    int num = int.Parse(command[2]);

                    if (command[1]==">")
                    {
                        Console.WriteLine(string.Join(" ",input.FindAll(n=>n>num)));
                    }
                    else if (command[1]=="<")
                    {
                        Console.WriteLine(String.Join(" ",input.FindAll(n=>n<num)));
                    }
                    else if (command[1]==">=")
                    {
                        Console.WriteLine(String.Join(" ",input.FindAll(n=>n>=num)));
                    }
                    else if (command[1]=="<=")
                    {
                        Console.WriteLine(string.Join(" ",input.FindAll(n=>n<=num)));
                    }
                }
                
            }
        }
    }
}
