﻿using System;
using System.Numerics;

namespace _03._Big_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial.CalculateFactorial(n));
           
        }
    }
    public class Factorial
    {
        
      
        public static BigInteger CalculateFactorial(int n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
       
    }
}
