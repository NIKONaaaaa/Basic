namespace Articles
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string[] baseArticle = Console.ReadLine().Split(", ");
            Article article = new Article(baseArticle[0], baseArticle[1], baseArticle[2]);
            int commandCounter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= commandCounter; i++)
            {
                string[] commandInput = Console.ReadLine().Split(": ");
                switch (commandInput[0])
                {
                    case "Edit":
                        article.Edit(commandInput[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commandInput[1]);
                        break;
                    case "Rename":
                        article.Rename(commandInput[1]);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
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
        public void Edit(string newContent)
        {
            Content = newContent;
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