using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 2 10 5 - capacity - Queue
            //3 15 15 11 6 - bottles - Stack

            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int wastedWater = 0;

            while (true)
            {
                int currentBottle = bottles.Pop();

                if (currentBottle<cups.Peek())
                {
                    int currentCup = cups.Dequeue();
                    currentCup -= currentBottle;

                    while (true)
                    {
                        int currentBottleAgain = bottles.Pop();

                        if (currentBottleAgain<currentCup)
                        {
                            currentCup -= currentBottleAgain;
                        }
                        else
                        {
                            wastedWater += currentBottleAgain - currentCup;
                            break;
                        }

                        if (bottles.Count == 0)
                        {
                            Console.WriteLine($"Cups: {currentCup + " " + string.Join(" ", cups)}");
                            Console.WriteLine("Wasted litters of water: " + wastedWater);
                            return;
                        }
                    }
                }
                else if (currentBottle>=cups.Peek())
                {
                    wastedWater += currentBottle - cups.Peek();
                    cups.Dequeue();
                }
                if (cups.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                    Console.WriteLine("Wasted litters of water: " + wastedWater);
                    return;
                }
                else if (bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                    Console.WriteLine("Wasted litters of water: " + wastedWater);
                    return;
                }
            }
        }
    }
}
