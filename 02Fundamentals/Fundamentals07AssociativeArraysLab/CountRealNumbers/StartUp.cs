namespace CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> occurences = new SortedDictionary<double, int>();
            foreach (int number in numbers)
            {
                if (occurences.ContainsKey(number))
                {
                    occurences[number]++;
                }
                else
                {
                    occurences.Add(number, 1);
                }
            }
            foreach (var number in occurences)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}