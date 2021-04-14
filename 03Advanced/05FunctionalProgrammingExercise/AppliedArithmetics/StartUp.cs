namespace AppliedArithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Dictionary<string, Func<int, int>> commands = new Dictionary<string, Func<int, int>> { { "add", n => n + 1 }, { "multiply", n => n * 2 }, { "subtract", n => n - 1 } };
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else
                {
                    Func<int, int> operation = commands[command];
                    numbers = numbers.Select(operation).ToArray();
                }

                command = Console.ReadLine();
            }
        }
    }
}