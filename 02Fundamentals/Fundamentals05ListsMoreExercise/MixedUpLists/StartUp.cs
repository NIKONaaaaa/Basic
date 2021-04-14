namespace MixedUpLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            secondList.Reverse();
            int minRange, maxRange;
            if (firstList.Count > secondList.Count)
            {
                minRange = firstList[^1];
                maxRange = firstList[^2];
                firstList.RemoveRange(firstList.Count - 2, 2);
            }
            else
            {
                minRange = secondList[^1];
                maxRange = secondList[^2];
                secondList.RemoveRange(secondList.Count - 2, 2);
            }
            List<int> merge = new List<int>();
            for (int i = 0; i < firstList.Count; i++)
            {
                merge.Add(firstList[i]);
                merge.Add(secondList[i]);
            }
            foreach (int number in merge.OrderBy(value => value).Where(number => Math.Min(minRange, maxRange) < number && number < Math.Max(minRange, maxRange)))
            {
                Console.Write($"{number} ");
            }
        }
    }
}