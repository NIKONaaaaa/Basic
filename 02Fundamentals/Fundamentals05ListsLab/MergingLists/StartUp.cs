namespace MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string inputOne = Console.ReadLine(), inputTwo = Console.ReadLine();
            Console.WriteLine(MergeLists(inputOne, inputTwo));
            static string MergeLists(string listOne, string listTwo)
            {
                List<int> numbersOne = listOne.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                List<int> numbersTwo = listTwo.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                List<int> numbersMerged = new List<int>();
                for (int i = 0; i < Math.Min(numbersOne.Count, numbersTwo.Count); i++)
                {
                    numbersMerged.Add(numbersOne[i]);
                    numbersMerged.Add(numbersTwo[i]);
                }
                if (numbersOne.Count < numbersTwo.Count)
                {
                    numbersMerged.AddRange(GetRemainingElements(numbersOne, numbersTwo));
                }
                else if (numbersTwo.Count < numbersOne.Count)
                {
                    numbersMerged.AddRange(GetRemainingElements(numbersTwo, numbersOne));
                }
                return string.Join(" ", numbersMerged);
            }
            static List<int> GetRemainingElements(List<int> listShort, List<int> listLong)
            {
                List<int> numbers = new List<int>();
                for (int i = listShort.Count; i < listLong.Count; i++)
                {
                    numbers.Add(listLong[i]);
                }
                return numbers;
            }
        }
    }
}