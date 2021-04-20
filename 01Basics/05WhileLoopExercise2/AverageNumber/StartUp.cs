namespace AverageNumber
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            double number = 0;
            for (int i = 1; i <= counter; i++)
            {
                number += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{number / counter:f2}");
        }
    }
}