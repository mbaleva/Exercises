using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string command = string.Empty;
            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();

            while ((command=Console.ReadLine())!="END")
            {
                if (command=="green")
                {
                    int currentGreenLight = greenLight;
                    int currentFreeWindow = freeWindow;

                    int count = queue.Count();

                    for (int i = 0; i < count; i++)
                    {
                        if (currentGreenLight>=queue.Peek().Length
                            &&queue.Count>0)
                        {
                            currentGreenLight -= queue.Peek().Length;
                            stack.Push(queue.Dequeue());
                        }
                        else if (currentGreenLight < queue.Peek().Length&&queue.Count>0)
                        {
                            int totalTime = currentFreeWindow + currentGreenLight;

                            if (currentGreenLight<=0)
                            {
                                continue;
                            }
                            else if (totalTime>0&&totalTime>=queue.Peek().Length)
                            {
                                string currentCar = queue.Peek();
                                totalTime -= currentCar.Length;
                                stack.Push(queue.Dequeue());
                                currentFreeWindow = 0;
                                currentGreenLight = 0;
                            }
                            else if (totalTime>0&&totalTime<queue.Peek().Length)
                            {
                                string currentCar = queue.Peek();
                                Console.WriteLine("A crash happened!");
                                int hit = totalTime;
                                Console.WriteLine($"{currentCar} was hit at {currentCar[hit]}.");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{stack.Count} total cars passed the crossroads.");
        }
    }
}
