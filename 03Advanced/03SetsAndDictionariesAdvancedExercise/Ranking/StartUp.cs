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
            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string contestName = input.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
                string contestPassword = input.Split(":", StringSplitOptions.RemoveEmptyEntries)[1];
                contests.Add(contestName, contestPassword);
                input = Console.ReadLine();
            }
            Dictionary<string, Dictionary<string, int>> contestants = new Dictionary<string, Dictionary<string, int>>();
            string contestEntry = Console.ReadLine();
            while (contestEntry != "end of submissions")
            {
                string contest = contestEntry.Split("=>", StringSplitOptions.RemoveEmptyEntries)[0];
                string password = contestEntry.Split("=>", StringSplitOptions.RemoveEmptyEntries)[1];
                string contestantName = contestEntry.Split("=>", StringSplitOptions.RemoveEmptyEntries)[2];
                string asd = contestEntry.Split("=>", StringSplitOptions.RemoveEmptyEntries)[3];
                int contestPoints = int.Parse(asd);
                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (contestants.ContainsKey(contestantName))
                    {
                        if (contestants[contestantName].ContainsKey(contest))
                        {
                            if (contestants[contestantName][contest] < contestPoints)
                            {
                                contestants[contestantName][contest] = contestPoints;
                            }
                        }
                        else
                        {
                            contestants[contestantName].Add(contest, contestPoints);
                        }
                    }
                    else
                    {
                        contestants.Add(contestantName, new Dictionary<string, int>());
                        contestants[contestantName].Add(contest, contestPoints);
                    }
                }
                contestEntry = Console.ReadLine();
            }
            string bestContestant = "";
            int bestPoints = 0;
            foreach (var entries in contestants)
            {
                if (entries.Value.Values.Sum() > bestPoints)
                {
                    bestPoints = entries.Value.Values.Sum();
                    bestContestant = entries.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestContestant} with total {bestPoints} points.\nRanking:");
            foreach (var contestant in contestants.OrderBy(x => x.Key))
            {
                Console.WriteLine(contestant.Key);
                foreach (var kvp in contestant.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}