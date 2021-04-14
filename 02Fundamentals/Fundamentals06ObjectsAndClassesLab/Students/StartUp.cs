namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
    class StartUp
    {
        static void Main()
        {
            List<Student> studentDirectory = new List<Student>();
            PopulateList(studentDirectory);
            PrintStudentInfo(studentDirectory, Console.ReadLine());
        }
        private static void PopulateList(List<Student> currentList)
        {
            string[] commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commandInput[0] != "end")
            {
                currentList.Add(new Student()
                {
                    FirstName = commandInput[0],
                    LastName = commandInput[1],
                    Age = int.Parse(commandInput[2]),
                    Hometown = commandInput[3]
                });
                commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
        private static void PrintStudentInfo(List<Student> studentList, string city)
        {
            foreach (Student student in studentList.Where(student => student.Hometown == city))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}