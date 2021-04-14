namespace SortEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers.OrderBy(value => value).Where(x => x % 2 == 0))
            {
                evenNumbers.Add(number);
            }
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}