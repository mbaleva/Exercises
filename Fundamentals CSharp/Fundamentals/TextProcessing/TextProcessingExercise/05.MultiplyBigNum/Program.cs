using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart('0');

            int num = int.Parse(Console.ReadLine());

            int temp = 0;

            var sb = new StringBuilder();

            if (num==0||input=="")
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var item in input.Reverse())
            {
                int digit = int.Parse(item.ToString());

                int multiply = digit * num+temp;

                int lastDigit = multiply % 10;
                temp = multiply / 10;

                sb.Insert(0, lastDigit);
            }
            if (temp>0)
            {
                sb.Insert(0, temp);
            }
          

            Console.WriteLine(sb.ToString());
        }
    }
}
