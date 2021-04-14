namespace ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
            int divisor = int.Parse(Console.ReadLine());
            bool Divisible(int n) => n % divisor == 0;
            Console.WriteLine(string.Join(" ", numbers.Where(n => !Divisible(n))));
        }
    }
}