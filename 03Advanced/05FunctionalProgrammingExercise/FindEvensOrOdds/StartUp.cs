namespace FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            string evenOdd = Console.ReadLine();
            Dictionary<string, Predicate<int>> evenOrOddPredicate = new Dictionary<string, Predicate<int>> { { "even", n => n % 2 == 0 }, { "odd", n => n % 2 != 0 } };
            Predicate<int> evenOrOdd = evenOrOddPredicate[evenOdd];
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (evenOrOdd(i))
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}