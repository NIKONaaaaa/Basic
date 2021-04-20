namespace ExamPreparation
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int failMax = int.Parse(Console.ReadLine());
            int failCount = 0;
            string problemLast = "";
            double problemCount = 0;
            double gradeTotal = 0;
            while (true)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    Console.WriteLine($"Average score: {gradeTotal / problemCount:f2}");
                    Console.WriteLine($"Number of problems: {problemCount}");
                    Console.WriteLine($"Last problem: {problemLast}");
                    break;
                }
                problemLast = problemName;
                double gradeCurrent = double.Parse(Console.ReadLine());
                if (gradeCurrent <= 4.00)
                {
                    failCount++;
                    if (failCount == failMax)
                    {
                        Console.WriteLine($"You need a break, {failCount} poor grades.");
                        break;
                    }
                }
                gradeTotal += gradeCurrent;
                problemCount++;
            }
        }
    }
}