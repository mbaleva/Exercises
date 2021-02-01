using System;

namespace _02.Article
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] title = Console.ReadLine().Split(", ");

            Article article = new Article(title[0],title[1],title[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(": ");

                if (cmd[0]=="Edit")
                {
                    article.Edit(cmd[1]);
                }
                else if (cmd[0]== "ChangeAuthor")
                {
                    article.ChangeAuthor(cmd[1]);
                }
                else if (cmd[0]== "Rename")
                {
                    article.Rename(cmd[1]);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
