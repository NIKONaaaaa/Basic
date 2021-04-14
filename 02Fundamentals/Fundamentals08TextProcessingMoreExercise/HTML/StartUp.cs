namespace HTML
{
    using System;
    class StartUp
    {
        static void Main()
        {
            for (int i = 1; ; i++)
            {
                string text = Console.ReadLine();
                if (text == "end of comments")
                {
                    break;
                }
                if (i == 1)
                {
                    Console.WriteLine($"<h1>\n   {text}\n</h1>");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"<article>\n   {text}\n</article>");
                }
                else
                {
                    Console.WriteLine($"<div>\n   {text}\n</div>");
                }
            }
        }
    }
}