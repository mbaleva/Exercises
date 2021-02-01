using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string somethingToRemove = Console.ReadLine().ToLower();

            
            string word = Console.ReadLine();

            int index = word.IndexOf(somethingToRemove);

            while (index!=-1)
            {
                
               word =  word.Remove(index, somethingToRemove.Length);

               index = word.IndexOf(somethingToRemove);
            }
            Console.WriteLine(word);
        }
    }
}
