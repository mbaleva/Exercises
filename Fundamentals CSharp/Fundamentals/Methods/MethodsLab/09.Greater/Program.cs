using System;

namespace _09.Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();

            GetMax(command, firstText, secondText);
        }
        static void  GetMax(string command,string firstText, string secondText)
        {
            int result = 0;
            int result2 = 0;
            if (command == "int")
            {
                result = int.Parse(firstText);
                result2 = int.Parse(secondText);

                if (result > result2)
                {
                    Console.WriteLine(firstText);
                }
                else if (result < result2)
                {
                    Console.WriteLine(secondText);
                }
            }
            else if (command == "char")
            {
                result = char.Parse(firstText);
                result2 = char.Parse(secondText);

                if (result >result2)
                {
                    Console.WriteLine(firstText);
                }
                else if (result < result2)
                {
                    Console.WriteLine(secondText);
                }
            }
            
            else if (command == "string")
            {
                int compare = firstText.CompareTo(secondText);

                if (compare > 0)
                {
                    Console.WriteLine(firstText);
                }
                else
                {
                    Console.WriteLine(secondText);              
                }
            }

        }
    }
}
