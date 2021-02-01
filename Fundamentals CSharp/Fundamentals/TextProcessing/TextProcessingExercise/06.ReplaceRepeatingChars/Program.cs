using System;
using System.Text;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string pesho = Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = 0; i < pesho.Length-1; i++)
            {
                if (pesho[i]!=pesho[i+1])
                {
                    sb.Append(pesho[i]);
                }
            }
            var gosho = pesho[pesho.Length - 1];
            sb.Append(gosho);
            Console.WriteLine(sb.ToString());
        }
    }
}
