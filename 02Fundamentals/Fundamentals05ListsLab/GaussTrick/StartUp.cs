namespace GaussTrick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(Gauss(Console.ReadLine()));
            static string Gauss(string input)
            {
                List<double> numbers = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                int originalLength = numbers.Count;
                for (int i = 0; i < originalLength / 2; i++)
                {
                    numbers[i] += numbers[^1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
                return string.Join(" ", numbers);
            }
        }
    }
}