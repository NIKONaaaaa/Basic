namespace Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, int> participantResults = new Dictionary<string, int>();
            Console.ReadLine().Split(", ").ToList().ForEach(name => participantResults.Add(name, 0));
            const string nameMatch = @"[A-Za-z]+", numberMatch = @"\d";
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection letters = Regex.Matches(input, nameMatch), numbers = Regex.Matches(input, numberMatch);
                string name = "";
                int distance = 0;
                foreach (Match match in letters)
                {
                    name += match;
                }
                foreach (Match match in numbers)
                {
                    distance += int.Parse(match.ToString());
                }
                if (participantResults.ContainsKey(name))
                {
                    participantResults[name] += distance;
                }
                input = Console.ReadLine();
            }
            string[] place = { "1st", "2nd", "3rd" };
            List<string> output = participantResults.Where(distance => distance.Value > 0).OrderByDescending(distance => distance.Value).Select(name => name.Key).ToList();
            int podiumPlaces = (output.Count > 3) ? 3 : output.Count;
            for (int i = 0; i < podiumPlaces; i++)
            {
                Console.WriteLine($"{place[i]} place: {output[i]}");
            }
        }
    }
}