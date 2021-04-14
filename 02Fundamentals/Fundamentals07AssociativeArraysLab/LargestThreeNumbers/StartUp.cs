namespace LargestThreeNumbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] sortedNumbers = numbers.OrderByDescending(number => number).ToArray();
            if (sortedNumbers.Length < 3)
            {
                Console.WriteLine(string.Join(" ", sortedNumbers));
            }
            else
            {
                for (int i = 0; i <3; i++)
                {
                    Console.Write(sortedNumbers[i] + " ");
                }
            }
        }
    }
}