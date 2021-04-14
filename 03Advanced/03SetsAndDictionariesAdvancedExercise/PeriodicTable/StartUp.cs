namespace PeriodicTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string element in input)
                {
                    elements.Add(element);
                }
            }
            List<string> sortedElements = elements.ToList();
            Console.WriteLine(string.Join(" ", sortedElements.OrderBy(name => name)));
        }
    }
}