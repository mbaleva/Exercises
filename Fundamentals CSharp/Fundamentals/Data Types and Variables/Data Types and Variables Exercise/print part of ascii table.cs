using System;
using System.Net.Http.Headers;

namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            for (int i = a; i <= b; i++)
            {
                char letter = (char)i;
                Console.Write($"{letter} ");
            }
            
        }
    }
}