using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string firstRow = new string('*', 2 * n);
            string emptySpace = new string(' ', n);
            string bridge = new string('|', n);
            string lens = string.Format($"{'*'}{new string('/', 2 * n - 2)}{'*'}");
            string frame = string.Format($"{lens}{bridge}{lens}");

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine($"{firstRow}{emptySpace}{firstRow}");
                }
                else if (i == (n - 1) / 2 )
                {
                    Console.WriteLine($"{frame}");
                }
                else
                {
                    Console.WriteLine($"{lens}{emptySpace}{lens}");
                }
            }
        }
    }
}
