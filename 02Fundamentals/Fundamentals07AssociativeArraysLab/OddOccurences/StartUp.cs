namespace OddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (occurences.ContainsKey(wordInLowerCase))
                {
                    occurences[wordInLowerCase]++;
                }
                else
                {
                    occurences.Add(wordInLowerCase, 1);
                }
            }
            foreach (var entry in occurences.Where(entry => entry.Value % 2 == 1))
            {
                Console.Write(entry.Key + " ");
            }
        }
    }
}