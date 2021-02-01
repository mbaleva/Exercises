using System;
using System.Numerics;


namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger sum = 0;
            BigInteger max = 0;
            int snowball = 0;
            int snowballTime = 0;
            int snowballQA = 0;
            for (int i = 1; i <= n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int snowTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());



                if (snowTime > 0)
                {
                    sum = BigInteger.Pow((snow / snowTime), snowballQuality);


                    if (sum > max)
                    {
                        max = sum;
                        snowball = snow;
                        snowballTime = snowTime;
                        snowballQA = snowballQuality;
                    }
                }

            }
            Console.WriteLine($"{snowball} : {snowballTime} = {max} ({snowballQA})");
        }
    }
}