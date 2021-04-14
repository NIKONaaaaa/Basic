namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.IO;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader("words.txt"))
            {
                wordOccurrences = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToDictionary(word => word, word => 0);
            }
            Regex onlyWords = new Regex(@"\w+");
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    foreach (Match match in onlyWords.Matches(line.ToLower()))
                    {
                        if (wordOccurrences.ContainsKey(match.Value))
                        {
                            wordOccurrences[match.Value]++;
                        }
                    }
                    line = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (KeyValuePair<string, int> kvp in wordOccurrences.OrderByDescending(quantity => quantity.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}