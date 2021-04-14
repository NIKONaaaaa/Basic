namespace Grades
{
    using System;
    class StartUp
    {
        static void Main()
        {
            PrintInWords(double.Parse(Console.ReadLine()));
        }
        private static void PrintInWords(double grade)
        {
            if (grade <= 4.49)
            {
                if (grade <= 2.99) Console.WriteLine("Fail");
                else if (grade <= 3.49) Console.WriteLine("Poor");
                else Console.WriteLine("Good");
            }
            else if (5.50 <= grade) Console.WriteLine("Excellent");
            else Console.WriteLine("Very good");
        }
    }
}