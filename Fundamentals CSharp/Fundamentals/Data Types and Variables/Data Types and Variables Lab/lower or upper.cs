using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());


            if (a >='A'&&a<='Z')
            {
                Console.WriteLine($"upper-case");
            }
            else
            {
                Console.WriteLine($"lower-case");
            }
        }
    }
}
