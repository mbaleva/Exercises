using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToList();
            string message = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int sum = CalculateSum(currentNumber);

                char currentChar = GetCharFromMessage(sum, message);
                Console.Write(currentChar);

                int realIndex = CalculateRealIndex(sum, message);
                string newMessage = message.Remove(realIndex, 1);
                message = newMessage;
            }
            Console.WriteLine();
        }
        static int CalculateSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                sum += currentNumber;
                number /= 10;
            }

            return sum;
        }
        static char GetCharFromMessage(int index, string message)
        {
            int countIndex = 0;

            for (int i = 0; i < index; i++)
            {
                countIndex++;

                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }

            char currentChar = message[countIndex];
            return currentChar;
        }
        static int CalculateRealIndex(int index, string message)
        {
            int countIndex = 0;

            for (int i = 0; i < index; i++)
            {
                countIndex++;

                if (countIndex == message.Length)
                {
                    countIndex = 0;
                }
            }
            return countIndex;
        }

    }
}
