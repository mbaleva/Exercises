using System;
using System.Net.Http.Headers;

namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int countCourses = (int)Math.Ceiling((double)n/p);
            Console.WriteLine(countCourses);
        }
    }
}