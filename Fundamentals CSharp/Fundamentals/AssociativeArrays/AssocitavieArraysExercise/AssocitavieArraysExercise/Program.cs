using System;

namespace AssociativeArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
           
            double P = 2 * (a + b);
            double S = a * b;

            Console.WriteLine("Периметъра е" +" " +P);
            Console.WriteLine("Лицето е"+" "+S);
        }
    }
}
