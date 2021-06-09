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
            Console.WriteLine(CompareFiles("../../../actualResults.txt", "../../../expectedResult.txt"));
        }

        static string CompareFiles(string resultsPath, string expectedResultsPath)
        {
            byte[] results = File.ReadAllBytes(resultsPath);
            byte[] expectedResults = File.ReadAllBytes(expectedResultsPath);
            if (results.Length == expectedResults.Length)
            {
                for (int i = 0; i < results.Length; i++)
                {
                    if (results[i] != expectedResults[i])
                    {
                        return "Results do not match expected results!";
                    }
                }
                return "Results match expected results!";
            }
            return "Results do not match expected results!";
        }
    }
}