namespace ListOfPredicates
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int upperBound = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            static bool Filter(int number, int[] divisors)
            {
                return divisors.All(divisor => number % divisor == 0);
            }
            Console.WriteLine(string.Join(" ", Enumerable.Range(1, upperBound).Where(number => Filter(number, divisors))));
        }
    }
}