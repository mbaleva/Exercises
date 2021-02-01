using System;
using System.Numerics;
using System.Text;

namespace DataTypesAndVariablesMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                string firstNumberAssString = string.Empty;
                string secondNumberAssString = string.Empty;

                bool isFirstNum = false;

                for (int j = 0; j < input.Length; j++)
                {
                    char letter = input[j];

                    if (isFirstNum == false)
                    {
                        if (letter == ' ')
                        {
                            isFirstNum = true;
                        }
                        else
                        {
                            firstNumberAssString += letter;
                        }
                    }
                    else
                    {
                        secondNumberAssString += letter;
                    }
                }
           


                int sum = 0;
                

                if (double.Parse(Convert.ToString(firstNumberAssString)) > double.Parse(Convert.ToString(secondNumberAssString)))
                {
                    for (int k = 0; k < Convert.ToString(firstNumberAssString).Length; k++)
                    {
                        bool symbol = int.TryParse(Convert.ToString(firstNumberAssString[k]), out int digit);
                        sum += digit;
                    }
                }
                else
                {
                    for (int k = 0; k < Convert.ToString(secondNumberAssString).Length; k++)
                    {
                        bool symbol = int.TryParse(Convert.ToString(secondNumberAssString[k]), out int digit);
                        sum += digit;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}