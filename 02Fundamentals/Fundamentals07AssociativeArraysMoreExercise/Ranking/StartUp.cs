namespace Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "end of contests")
            {
                contests.Add(input[0], input[1]);
                input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            SortedDictionary<string, Dictionary<string, int>> contestants = new SortedDictionary<string, Dictionary<string, int>>();
            input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "end of submissions")
            {
                if (contests.ContainsKey(input[0]) && contests[input[0]] == input[1])
                {
                    if (contestants.ContainsKey(input[2]))
                    {
                        if (!contestants[input[2]].ContainsKey(input[0]))
                        {
                            contestants[input[2]].Add(input[0], int.Parse(input[3]));
                        }
                        else if (contestants[input[2]][input[0]] < int.Parse(input[3]))
                        {
                            contestants[input[2]][input[0]] = int.Parse(input[3]);
                        }
                    }
                    else
                    {
                        contestants.Add(input[2], new Dictionary<string, int> { { input[0], int.Parse(input[3]) } });
                    }
                }
                input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            int maxPoints = 0;
            string winner = "";
            foreach (var (key, value) in contestants)
            {
                int totalPoints = value.Values.Sum();
                if (totalPoints <= maxPoints) continue;
                maxPoints = totalPoints;
                winner = key;
            }
            Console.WriteLine($"Best candidate is {winner} with total {maxPoints} points.\nRanking:");
            foreach (var (key, value) in contestants)
            {
                Console.WriteLine(key);
                foreach (var (exam, result) in value.OrderByDescending(points => points.Value))
                {
                    Console.WriteLine($"#  {exam} -> {result}");
                }
            }
        }
    }
}