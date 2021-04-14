namespace WordSynonyms
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            int lineCounter = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();
            for (int i = 0; i < lineCounter; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(synonym);
            }
            foreach (var word in words)
            {
                Console.Write($"{word.Key} - ");
                Console.Write(string.Join(", ", word.Value));
                Console.WriteLine();
            }
        }
    }
}