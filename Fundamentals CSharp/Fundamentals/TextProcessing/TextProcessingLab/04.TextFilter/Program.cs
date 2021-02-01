using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var gosho in arr)
            {
                if (text.Contains(gosho))
                {
                    text = text.Replace(gosho, new string('*', gosho.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
