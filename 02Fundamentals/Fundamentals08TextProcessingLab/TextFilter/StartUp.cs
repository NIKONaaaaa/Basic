namespace TextFilter
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (string word in bannedWords)
            {
                string replacement = "";
                foreach (char ch in word)
                {
                    replacement += "*";
                }
                text = text.Replace(word, replacement);
            }
            Console.WriteLine(text);
        }
    }
}