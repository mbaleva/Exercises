using System;
using System.Linq;
using System.Text;

namespace _04.CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string strings = Console.ReadLine();
     
            foreach (char item in strings)
            {
                char currentChar = (char)(item + 3);
                Console.Write(currentChar);
            }
        }
    }
}
