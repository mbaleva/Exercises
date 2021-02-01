using System;
using System.Net.Http.Headers;

namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            
            for (int i = 0; i <n; i++)
            {
                char firstLetter = (char)('a'+i);
                for (int k = 0; k < n; k++)
                {
                    char secondLetter = (char)('a' + k);
                    for (int d = 0; d <n; d++)
                    {
                        char thirdLetter = (char)('a' + d);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
            
        }
    }
}