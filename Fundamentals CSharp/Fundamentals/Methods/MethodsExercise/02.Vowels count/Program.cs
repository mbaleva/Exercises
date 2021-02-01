using System;

namespace _02.Vowels_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Console.WriteLine(vowelsCount(name));
        }
        static string vowelsCount(string name)
        {
            int counter = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i]=='a'||name[i]=='o'||name[i]=='u'||name[i]=='e'||name[i]=='i'||name[i]=='y'||
                    name[i] == 'A' || name[i] == 'O' || name[i] == 'U' || name[i] == 'E' || name[i] == 'I' || name[i] == 'Y')
                {
                    counter++;
                }
            }

            return counter.ToString();
        }
    }
}
