namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(SumNumbers(Console.ReadLine()));
            static string SumNumbers(string input)
            {
                List<double> numbers = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        i = -1;
                    }
                }
                return (string.Join(" ", numbers));
            }
        }
    }
}