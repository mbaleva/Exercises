using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Article_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            List<Article> totalArticle = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(", ");

                Article article = new Article(cmd[0],cmd[1],cmd[2]);

                totalArticle.Add(article);
            }
            string lastCmd = Console.ReadLine();

            if (lastCmd =="title")
            {
                totalArticle = totalArticle.OrderBy(a => a.Title).ToList();
            }
            else if (lastCmd == "content")
            {
                totalArticle = totalArticle.OrderBy(a => a.Content).ToList();
            }
            else if (lastCmd == "author")
            {
                totalArticle = totalArticle.OrderBy(a => a.Author).ToList();
            }
            Console.WriteLine
                (string.Join(Environment.NewLine, totalArticle));
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
