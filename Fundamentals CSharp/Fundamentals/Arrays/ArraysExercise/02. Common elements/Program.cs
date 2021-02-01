using System;

namespace _02._Common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();



            for (int k = 0; k < firstArray.Length; k++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[k] == secondArray[j])
                    {
                        Console.Write($"{firstArray[k]} ");
                    }
                }
            }

        }
    }
}
