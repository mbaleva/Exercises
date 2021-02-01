using System;

namespace _01.AdvertismentMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                AdvertismentMessage AdvMessage =
                    new AdvertismentMessage();

                Console.WriteLine(AdvMessage.GenerateMessage());
            }
        }
    }
    public class AdvertismentMessage
    {
        public string[] Phrases = new string[] {
        "Excellent product.", "Such a great product.",
        "I always use that product.",
        "Best product of its category.",
        "Exceptional product.",
        "I can’t live without this product." };

        public string[] Events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

        public string[] Author = new string[]
           {
               "Diana", "Petya",
               "Stella", "Elena",
               "Katya", "Iva",
               "Annie", "Eva"
           };

        public string[] City = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };


        public string GenerateMessage()
        {
            Random rand = new Random();

            string randomPhrases =
                Phrases[rand.Next(0, Phrases.Length - 1)];
            string randomEvents =
                Events[rand.Next(0, Events.Length - 1)];
            string randomAuthor =
                Author[rand.Next(0, Author.Length - 1)];
            string randomCity =
                City[rand.Next(0, City.Length - 1)];

            return $"{randomPhrases} {randomEvents} {randomAuthor} - {randomCity}";
        }


    }
}
