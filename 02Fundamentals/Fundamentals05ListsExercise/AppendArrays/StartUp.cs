namespace AppendArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> numbers = new List<int>();
            foreach (var inputString in input)
            {
                numbers.AddRange(inputString.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}