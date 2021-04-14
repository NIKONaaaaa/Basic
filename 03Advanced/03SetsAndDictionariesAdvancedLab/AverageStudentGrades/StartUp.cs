namespace AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < input; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!students.ContainsKey(studentInfo[0]))
                {
                    students.Add(studentInfo[0], new List<decimal>());
                }
                students[studentInfo[0]].Add(decimal.Parse(studentInfo[1]));
            }
            foreach (var (student, grades) in students)
            {
                Console.Write($"{student} -> ");
                foreach (decimal grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {grades.Average():f2})\n");
            }
        }
    }
}