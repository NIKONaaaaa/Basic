namespace Articles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int articleCounter = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>(articleCounter);
            for (int i = 1; i <= articleCounter; i++)
            {
                string[] articleInfo = Console.ReadLine().Split(", ");
                Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);
                articles.Add(article);
            }
            FilterArticles(Console.ReadLine(), articles);
        }
        private static void FilterArticles(string filterInput, List<Article> articles)
        {
            if (filterInput == "title")
            {
                articles = articles.OrderBy(entry => entry.Title).ToList();
            }
            else if (filterInput == "content")
            {
                articles = articles.OrderBy(entry => entry.Content).ToList();
            }
            else
            {
                articles = articles.OrderBy(entry => entry.Author).ToList();
            }
            foreach (Article item in articles)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}