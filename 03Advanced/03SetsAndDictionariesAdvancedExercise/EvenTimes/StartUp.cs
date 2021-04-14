namespace EvenTimes
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }
            foreach (var (number, times) in numbers)
            {
                if (times % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}