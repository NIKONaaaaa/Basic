namespace Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            var courses = new Dictionary<string, List<string>>();
            string[] commandInput = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            while (commandInput[0] != "end")
            {
                if (!courses.ContainsKey(commandInput[0]))
                {
                    courses.Add(commandInput[0], new List<string>() { commandInput[1] });
                }
                else
                {
                    courses[commandInput[0]].Add(commandInput[1]);
                }
                commandInput = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (KeyValuePair<string, List<string>> course in courses.OrderByDescending(studentCount => studentCount.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (string student in course.Value.OrderBy(name => name))
                {
                    Console.WriteLine(string.Join(Environment.NewLine, $"-- {student}"));
                }
            }
        }
    }
}