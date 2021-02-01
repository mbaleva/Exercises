using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string conditionToStopTheLoop = string.Empty;


            while ((conditionToStopTheLoop = Console.ReadLine()) != "3:1")
            {
                List<string> command = conditionToStopTheLoop
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex > input.Count - 1)
                    {
                        startIndex = input.Count - 1;
                    }
                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }
                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    //Ivo Johny Tony Bony Mony
                    //merge 0 3
                    //merge 3 4
                    //merge 0 3
                    //3:1

                    List<string> temp = new List<string>();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        temp.Add(input[i]);
                    }
                    input[startIndex] = string.Join("", temp);
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        input.RemoveAt(startIndex + 1);
                    }

                }
                else if (command[0] == "divide")
                {
                    //abcd efgh ijkl mnop qrst uvwx yz
                    //merge 4 10
                    //divide 4 5
                    //3:1
                    List<string> temp = new List<string>();
                    string wordToDivide = input[int.Parse(command[1])];
                    int partitions = int.Parse(command[2]);
                    int length = wordToDivide.Length / int.Parse(command[2]);
                    int lengthIfIsOdd = wordToDivide.Length % int.Parse(command[2]);

                    

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            length += lengthIfIsOdd;
                        }
                        temp.Add(wordToDivide.Substring(0, length));
                        wordToDivide = wordToDivide.Remove(0, length);
                    }
                    input.RemoveAt(int.Parse(command[1]));
                    input.InsertRange(int.Parse(command[1]), temp);
                }

            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

