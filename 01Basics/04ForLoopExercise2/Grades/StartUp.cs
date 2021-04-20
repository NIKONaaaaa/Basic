namespace Grades
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            double studentA = 0;
            double studentB = 0;
            double studentC = 0;
            double studentF = 0;
            double gradeSum = 0;
            for (int i = 1; i <= studentCount; i++)
            {
                double gradeCurrent = double.Parse(Console.ReadLine());
                gradeSum += gradeCurrent;
                if (4 <= gradeCurrent)
                {
                    if (gradeCurrent <= 4.99)
                    {
                        studentB++;
                    }
                    else
                    {
                        studentA++;
                    }
                }
                else
                {
                    if (3 <= gradeCurrent)
                    {
                        studentC++;
                    }
                    else
                    {
                        studentF++;
                    }
                }
            }
            Console.WriteLine($"Top students: {(studentA / studentCount) * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(studentB / studentCount) * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(studentC / studentCount) * 100:f2}%");
            Console.WriteLine($"Fail: {(studentF / studentCount) * 100:f2}%");
            Console.WriteLine($"Average: {gradeSum / studentCount:f2}");
        }
    }
}