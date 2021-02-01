using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            //KeyRevolver
            int bulletPrice = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int value = int.Parse(Console.ReadLine());

            int countUsedBullets = 0;
            int countBarrel = 0;

            while (stack.Count>0&&queue.Count>0)
            {
                //50
                //2
                //11 10 5 11 10 20
                //15 13 16
                //1500

                if (stack.Peek()<=queue.Peek())
                {
                    Console.WriteLine("Bang!");
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    stack.Pop();
                }
                countBarrel++;

                if (countBarrel==size&&stack.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    countBarrel = 0;
                }
                countUsedBullets++;
            }
            if (stack.Count>=0&&queue.Count==0)
            {
                var profit = value - (countUsedBullets * bulletPrice);
                Console.WriteLine($"{stack.Count} bullets left. Earned ${profit}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
            }
        }
    }
}
