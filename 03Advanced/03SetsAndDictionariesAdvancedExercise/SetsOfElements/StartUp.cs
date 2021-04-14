namespace SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for (int i = 0; i < input[0]; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < input[1]; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }
            first.IntersectWith(second);
            Console.WriteLine(string.Join(" ", first));
        }
    }
}