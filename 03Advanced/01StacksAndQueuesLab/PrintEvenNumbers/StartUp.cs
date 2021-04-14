namespace PrintEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            List<int> output = new List<int>();
            while (0 < numbers.Count)
            {
                if (numbers.Peek() % 2 == 0)
                {
                    output.Add(numbers.Peek());
                }
                numbers.Dequeue();
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}