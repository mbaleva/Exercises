using System;

namespace _01._Sign_of_integer_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Grade(number);
        }

        static void Grade(int n)
        {
            if (n>0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
