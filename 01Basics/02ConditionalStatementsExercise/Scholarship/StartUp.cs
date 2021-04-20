namespace Scholarship
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());
            double socialStipend = Math.Floor(minWage * 0.35);
            double gradeStipend = Math.Floor(grade * 25);
            if (income < minWage && grade >= 4.5 && grade < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialStipend} BGN");
            }
            else if (grade >= 5.5 && (gradeStipend >= socialStipend || income > minWage))
            {
                Console.WriteLine($"You get a scholarship for excellent results {gradeStipend} BGN");
            }
            else if (grade >= 5.5 && gradeStipend < socialStipend && income < minWage)
            {
                Console.WriteLine($"You get a Social scholarship {socialStipend} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}