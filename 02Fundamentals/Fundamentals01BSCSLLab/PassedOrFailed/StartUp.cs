namespace PassedOrFailed
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            if (3 <= grade)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}