namespace StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            string[] command = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    numbers.Push(int.Parse(command[1]));
                    numbers.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove" && int.Parse(command[1]) <= numbers.Count)
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        numbers.Pop();
                    }
                }
                command = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine("Sum: " + numbers.Sum());
        }
    }
}