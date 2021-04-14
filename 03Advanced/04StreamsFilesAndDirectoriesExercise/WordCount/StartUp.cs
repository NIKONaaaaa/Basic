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
            Dictionary<string, int> wordOccurrences = File.ReadAllLines("../../../words.txt").ToDictionary(word => word, word => 0);
            string[] lines = File.ReadAllLines("../../../text.txt");
            foreach (string line in lines)
            {
                foreach (Match match in Regex.Matches(line.ToLower(), @"\w+"))
                {
                    if (wordOccurrences.ContainsKey(match.Value))
                    {
                        wordOccurrences[match.Value]++;
                    }
                }
            }
            List<string> results = wordOccurrences.OrderByDescending(quantity => quantity.Value).Select(kvp => $"{kvp.Key} - {kvp.Value}").ToList();
            File.WriteAllText("../../../actualResults.txt", string.Join(Environment.NewLine, results));
        }
    }
}