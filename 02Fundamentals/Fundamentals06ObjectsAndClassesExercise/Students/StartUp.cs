namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            PopulateStudents(students, int.Parse(Console.ReadLine()));
            PrintStudentsByGrade(students);
        }
        private static void PopulateStudents(List<Student> students, int studentCount)
        {
            for (int i = 1; i<= studentCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student(input[0], input[1], float.Parse(input[2]));
                students.Add(student);
            }
        }
        private static void PrintStudentsByGrade(List<Student> students)
        {
            foreach (Student student in students.OrderByDescending(entry => entry.Grade))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }
        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}