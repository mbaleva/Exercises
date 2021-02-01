using System;


namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            a += b;
            a /= c;
            a *= d;
            Console.WriteLine(a);
        }
    }
}