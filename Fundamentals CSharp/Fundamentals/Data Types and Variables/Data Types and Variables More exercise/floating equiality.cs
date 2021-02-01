using System;
using System.Numerics;
using System.Text;

namespace DataTypesAndVariablesMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());


            if (a>b)
            {
                decimal diff = a - b;
                if (diff >= 0.000001M)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
            else
            {
                decimal diff = b-a;

                if (diff>= 0.000001M)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
           
        }
    }
}
