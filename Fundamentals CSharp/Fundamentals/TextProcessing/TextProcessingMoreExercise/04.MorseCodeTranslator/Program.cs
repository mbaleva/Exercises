using System;
using System.Text;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();


            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                string currentWord = arr[i];

                if (currentWord=="|")
                {
                    sb.Append(" ");
                }
                else if (currentWord==".-")
                {
                    sb.Append("A");
                }
                else if (currentWord=="-...")
                {
                    sb.Append("B");
                }
                else if (currentWord=="-.-.")
                {
                    sb.Append("C");
                }
                else if (currentWord=="-..")
                {
                    sb.Append("D");
                }
                else if (currentWord == ".")
                {
                    sb.Append("E");
                }
                else if (currentWord == "..-.")
                {
                    sb.Append("F");
                }
                else if (currentWord == "--.")
                {
                    sb.Append("G");
                }
                else if (currentWord=="....")
                {
                    sb.Append("H");
                }
                else if (currentWord == "..")
                {
                    sb.Append("I");
                }
                else if (currentWord==".---")
                {
                    sb.Append("J");
                }
                else if (currentWord=="-.-")
                {
                    sb.Append("K");
                }
                else if (currentWord==".-..")
                {
                    sb.Append("L");
                }
                else if (currentWord == "--")
                {
                    sb.Append("M");
                }
                else if (currentWord == "-.")
                {
                    sb.Append("N");
                }
                else if (currentWord == "---")
                {
                    sb.Append("O");
                }
                else if (currentWord == ".--.")
                {
                    sb.Append("P");
                }
                else if (currentWord == "--.-")
                {
                    sb.Append("Q");
                }
                else if (currentWord == ".-.")
                {
                    sb.Append("R");
                }
                else if (currentWord == "...")
                {
                    sb.Append("S");
                }
                else if (currentWord == "-")
                {
                    sb.Append("T");
                }
                else if (currentWord == "..-")
                {
                    sb.Append("U");
                }
                else if (currentWord == "...-")
                {
                    sb.Append("V");
                }
                else if (currentWord == ".--")
                {
                    sb.Append("W");
                }
                else if (currentWord == "-..-")
                {
                    sb.Append("X");
                }
                else if (currentWord == "-.--")
                {
                    sb.Append("Y");
                }
                else if (currentWord == "--..")
                {
                    sb.Append("Z");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
