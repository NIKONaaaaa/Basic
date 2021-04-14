namespace RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(ReverseRemove(Console.ReadLine()));
            static string ReverseRemove(string input)
            {
                List<int> numbers = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                numbers.Reverse();
                numbers.RemoveAll(number => number < 0);
                if (numbers.Count == 0)
                {
                    return "empty";
                }
                else
                {
                    return string.Join(" ", numbers);
                }
            }
        }
    }
}