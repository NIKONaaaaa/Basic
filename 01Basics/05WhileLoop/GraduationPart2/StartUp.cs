namespace GraduationPart2
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int failCounter = 0;
            int grade = 1;
            double gradeTotal = 0;
            while (grade <= 12 && failCounter < 2)
            {
                double gradeAverage = double.Parse(Console.ReadLine());
                if (gradeAverage < 4.00)
                {
                    failCounter++;
                }
                else
                {
                    gradeTotal += gradeAverage;
                    grade++;
                }
            }
            if (failCounter == 2)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradeTotal / 12:f2}");
            }
        }
    }
}