using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_don_t_go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int sum = 0;

            while (input.Count>0)
            {
                int index = int.Parse(Console.ReadLine());
             
         

                if (index<0)
                {
                    var numToRemove = input[0];
                    sum += numToRemove;
                    input[0] = input[input.Count - 1];


                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i]<=numToRemove)
                        {
                            input[i] += numToRemove;
                        }
                        else
                        {
                            input[i] -= numToRemove;
                        }
                    }
                }
                else if (index>=input.Count)
                {
              
                    var numToRemove = input[input.Count-1];
                    sum += numToRemove;
                    input[input.Count - 1] = input[0];
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= numToRemove)
                        {
                            input[i] += numToRemove;
                        }
                        else
                        {
                            input[i] -= numToRemove;
                        }
                    }
                }
                else
                {
                    
                    var numToRemove = input[index];
                    sum += numToRemove;
                    input.RemoveAt(index);

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= numToRemove)
                        {
                            input[i] += numToRemove;
                        }
                        else
                        {
                            input[i] -= numToRemove;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
