using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Kamino_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string input = string.Empty;



            //5
            //1!0!1!1!0
            //0!1!1!0!0
            //Clone them!
            int bestLength = int.MinValue;
            int bestSum = int.MinValue;
            int bestStartIndex = int.MinValue;
            int arrayCounter = 0;
            int bestIndex = int.MinValue;
            int[] newArr = new int[n];

            while ((input=Console.ReadLine()) != "Clone them!")
            {
                int[] array = input.Split('!',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                arrayCounter++;

                int length = 1;
                int startingIndex = 0;
                int sum = 0;
                int bestCurrentLength = 1;


                for (int i = 0; i < array.Length - 1; i++)
                {

                    if (array[i] == array[i + 1])
                    {
                        length++;

                    }
                    else
                    {
                        length = 1;

                    }
                    if (length > bestCurrentLength)
                    {
                        bestCurrentLength = length;

                        startingIndex = i;
                    }

                    sum += array[i];
                    


                }
               
                sum += array[array.Length - 1];
                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startingIndex;
                    bestSum = sum;
                    bestIndex = arrayCounter;
                    newArr = array.ToArray();
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (startingIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startingIndex;
                        bestSum = sum;
                        bestIndex = arrayCounter;
                        newArr = array.ToArray();
                    }
                    else if (startingIndex == bestStartIndex)
                    {
                        if (sum > bestSum)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startingIndex;
                            bestSum = sum;
                            bestIndex = arrayCounter;
                            newArr = array.ToArray();
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}