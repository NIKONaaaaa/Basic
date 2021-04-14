namespace SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<Exam> exams = new List<Exam>();
            SortedDictionary<string, Exam> examResults = new SortedDictionary<string, Exam>();
            string command = Console.ReadLine();
            while (command != "exam finished")
            {
                string name = command.Split("-")[0];
                string language = command.Split("-")[1];
                if (language == "banned")
                {
                    if (examResults.ContainsKey(name))
                    {
                        examResults.Remove(name);
                    }
                    command = Console.ReadLine();
                    continue;
                }
                int points = int.Parse(command.Split("-")[2]);
                if (examResults.ContainsKey(name))
                {
                    if (examResults[name].Points < points)
                    {
                        examResults[name].Points = points;
                    }
                    Exam exam = new Exam(language, points);
                    exams.Add(exam);
                }
                else
                {
                    Exam exam = new Exam(language, points);
                    exams.Add(exam);
                    examResults.Add(name, exam);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var (key, value) in examResults.OrderByDescending(points => points.Value.Points))
            {
                Console.WriteLine(string.Join(Environment.NewLine, $"{key} | {value.Points}"));
            }
            SortedDictionary<string, int> allLanguages = new SortedDictionary<string, int>();
            foreach (var item in exams)
            {
                if (allLanguages.ContainsKey(item.Language))
                {
                    allLanguages[item.Language]++;
                }
                else
                {
                    allLanguages.Add(item.Language, 1);
                }
            }
            Console.WriteLine("Submissions:");
            foreach (var (key, value) in allLanguages.OrderByDescending(count => count.Value))
            {
                Console.WriteLine(string.Join(Environment.NewLine, $"{key} - {value}"));
            }
        }
    }
    public class Exam
    {
        public string Language { get; set; }
        public int Points { get; set; }
        public Exam(string language, int points)
        {
            Language = language;
            Points = points;
        }
    }
}