namespace CountCharsInAString
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine().Replace(" ", "");
            Dictionary<char, int> occurences = new Dictionary<char, int>();
            foreach (char entry in input)
            {
                if (occurences.ContainsKey(entry))
                {
                    occurences[entry]++;
                }
                else
                {
                    occurences.Add(entry, 1);
                }
            }
            foreach (var entry in occurences)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}