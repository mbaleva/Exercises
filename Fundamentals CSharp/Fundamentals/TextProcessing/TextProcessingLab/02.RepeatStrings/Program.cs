using System;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            StringBuilder gosho = new StringBuilder();

            foreach (var item in arr)
            {
                int countToRepeat = item.Length;

                for (int i = 0; i < countToRepeat; i++)
                {
                    gosho.Append(item);
                }
            }
            Console.WriteLine(gosho);
        }
    }
}
