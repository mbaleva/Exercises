using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_lists
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

           

            List<int> result = new List<int>();


            if (firstList.Count >= secondList.Count)
            {

               
                for (int i = 0; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);

                    if (i<secondList.Count)
                    {
                        result.Add(secondList[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {

                    if (i < firstList.Count)
                    {
                        result.Add(firstList[i]);
                    } 
                    result.Add(secondList[i]);

                }
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
