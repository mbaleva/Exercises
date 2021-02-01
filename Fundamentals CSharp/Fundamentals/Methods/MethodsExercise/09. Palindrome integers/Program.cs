using System;

namespace _09._Palindrome_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            ;

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="END")
                {
                    Environment.Exit(0);
                }
                int num = int.Parse(command);
                int numberForEqual = num;
                int lastDigit = 0;
                string isEqual = string.Empty;


                for (int i = num; num > 0; i++)
                {
                    lastDigit = num % 10;
                    isEqual += lastDigit;
                    num /= 10;
                }
                if (isEqual == numberForEqual.ToString())
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
      
        
        
    }
}
