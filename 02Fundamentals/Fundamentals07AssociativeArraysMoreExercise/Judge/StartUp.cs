namespace Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> exams = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "no more time")
            {
                string contestant = input.Split(" -> ")[0];
                string exam = input.Split(" -> ")[1];
                int points = int.Parse(input.Split(" -> ")[2]);
                if (exams.ContainsKey(exam))
                {
                    if (!exams[exam].ContainsKey(contestant))
                    {
                        exams[exam].Add(contestant, points);
                    }
                    else if (exams[exam][contestant] < points)
                    {
                        exams[exam][contestant] = points;
                    }
                }
                else
                {
                    exams.Add(exam, new Dictionary<string, int> { { contestant, points } });
                }
                input = Console.ReadLine();
            }
            foreach (var (exam, participant) in exams)
            {
                int position = 1;
                Console.WriteLine($"{exam}: {participant.Count} participants");
                foreach (var (key, value) in participant.OrderByDescending(value => value.Value).ThenBy(name => name.Key))
                {
                    Console.WriteLine($"{position}. {key} <::> {value}");
                    position++;
                }
            }
            Console.WriteLine("Individual standings:");
            int rank = 1;
            Dictionary<string, int> results = new Dictionary<string, int>();
            foreach (var (exam, contestant) in exams)
            {
                foreach (var (name, points) in contestant)
                {
                    if (!results.ContainsKey(name))
                    {
                        results.Add(name, 0);
                    }
                    results[name] += points;
                }
            }
            foreach (var (name, points) in results.OrderByDescending(points => points.Value).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{rank}. {name} -> {points}");
                rank++;
            }
        }
    }
}