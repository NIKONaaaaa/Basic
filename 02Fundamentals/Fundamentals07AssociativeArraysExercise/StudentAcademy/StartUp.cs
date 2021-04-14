namespace StudentAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int studentCounter = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentList = new Dictionary<string, List<double>>();
            for (int i = 1; i <= studentCounter; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (!studentList.ContainsKey(studentName))
                {
                    studentList.Add(studentName, new List<double>() { studentGrade });
                }
                else
                {
                    studentList[studentName].Add(studentGrade);
                }
            }
            foreach (KeyValuePair<string, List<double>> student in studentList.OrderByDescending(grade => grade.Value.Average()).Where(averageGrade => 4.5 <= averageGrade.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}