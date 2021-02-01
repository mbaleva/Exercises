using System;

namespace _02.Randomize_words
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer random = new StringRandomizer();
            random.words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            random.Randomize();
            random.PrintWords();
        }
    }
    public class StringRandomizer
    {
        public string[] words;
        public void Randomize()
        {
            Random rand = new Random();

            for (int i = 0; i < this.words.Length; i++)
            {
                int randomPostion = rand.Next(0, this.words.Length);
                string temp = this.words[i];
                this.words[i] = words[randomPostion];
                this.words[randomPostion] = temp;
            }
        }
       public void PrintWords()
        {
            Console.WriteLine(string.Join(Environment.NewLine, words));

        }
    }
}
