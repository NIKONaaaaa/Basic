namespace CustomMinFunction
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            static int FindMinNumber(int x, int y) => x < y ? x : y;
            Console.WriteLine(numbers.Aggregate(int.MaxValue, FindMinNumber));
        }
    }
}