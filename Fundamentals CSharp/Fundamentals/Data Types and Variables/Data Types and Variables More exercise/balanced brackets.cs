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

            int counterForOpenenigBrackets = 0;
            int counterForClosingBrackets = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == ")"&&counterForOpenenigBrackets==0)
                {
                    Console.WriteLine($"UNBALANCED");
                    return;
                }
                if (input == "(")
                {
                    counterForOpenenigBrackets++;
                    if (counterForOpenenigBrackets==2)
                    {
                        Console.WriteLine($"UNBALANCED");
                        return;
                    }
                }
                if (input == ")")
                {
                    counterForClosingBrackets++;
                    if (counterForClosingBrackets==2)
                    {
                        Console.WriteLine($"UNBALANCED");
                        return;
                    }
                }
                if (counterForOpenenigBrackets==1&&counterForClosingBrackets==1)
                {
                    counterForClosingBrackets = 0;
                    counterForOpenenigBrackets = 0;
                }
            }
            if (counterForOpenenigBrackets==counterForClosingBrackets)
            {
                Console.WriteLine($"BALANCED");
            }
            else
            {
                Console.WriteLine($"UNBALANCED");
            }
        }
    }
}

