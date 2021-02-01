using System;
using System.Text;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ");

            var sb = new StringBuilder();
            bool flag = true;
            foreach (var item in arr)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {


                    for (int i =0;i<item.Length;i++)
                    {
                        char pesho = item[i];

                        if (!char.IsLetterOrDigit(pesho) && pesho != '-' && pesho != '_')
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        sb.AppendLine(item);
                    }
                    flag = true;
                   
                }
            }
            Console.WriteLine(sb);
        }
    }
}
