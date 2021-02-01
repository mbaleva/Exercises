using System;
using System.Text;

namespace _05.DigitstLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pesho = Console.ReadLine();

            var nums = new StringBuilder();
            var letters = new StringBuilder();
            var others = new StringBuilder();

            for (int i = 0; i < pesho.Length; i++)
            {
                if (char.IsDigit(pesho[i]))
                {
                    nums.Append(pesho[i]);
                }
                else if (char.IsLetter(pesho[i]))
                {
                    letters.Append(pesho[i]);
                }
                else
                {
                    others.Append(pesho[i]);
                }
            }
            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
