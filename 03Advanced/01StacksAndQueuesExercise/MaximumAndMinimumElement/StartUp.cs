namespace MaximumAndMinimumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int commandNumber = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < commandNumber; i++)
            {
                int[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (command[0] == 1)
                {
                    numbers.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    numbers.Pop();
                }
                else if (command[0] == 3 && 0 < numbers.Count)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (command[0] == 4 && 0 < numbers.Count)
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}