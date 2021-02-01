using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _07.StringExplosure
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int bomb = 0;
            //abv>1>1>2>2asdasd
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='>')
                {
                    bomb += int.Parse(input[i + 1].ToString());
                    continue;
                }
                if (bomb>0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    bomb--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
