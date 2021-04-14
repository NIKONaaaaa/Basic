namespace CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> valueOccurrences = new Dictionary<double, int>();
            foreach (double value in input)
            {
                if (valueOccurrences.ContainsKey(value))
                {
                    valueOccurrences[value] += 1;
                }
                else
                {
                    valueOccurrences.Add(value, 1);
                }
            }
            foreach (var (value, count) in valueOccurrences)
            {
                Console.WriteLine($"{value} - {count} times");   
            }
        }
    }
}