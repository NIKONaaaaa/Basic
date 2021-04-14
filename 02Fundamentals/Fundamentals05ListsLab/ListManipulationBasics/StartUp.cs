namespace ListManipulationBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(ListManipulation(Console.ReadLine()));
            static string ListManipulation(string input)
            {
                List<int> numbersInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                string[] commandInput = Console.ReadLine().Split(" ");
                while (commandInput[0] != "end")
                {
                    if (commandInput[0] == "Add")
                    {
                        numbersInput.Add(int.Parse(commandInput[1]));
                    }
                    else if (commandInput[0] == "Remove")
                    {
                        numbersInput.Remove(int.Parse(commandInput[1]));
                    }
                    else if (commandInput[0] == "RemoveAt")
                    {
                        numbersInput.RemoveAt(int.Parse(commandInput[1]));
                    }
                    else if (commandInput[0] == "Insert")
                    {
                        numbersInput.Insert(int.Parse(commandInput[2]), int.Parse(commandInput[1]));
                    }
                    commandInput = Console.ReadLine().Split(" ");
                }
                return string.Join(" ", numbersInput);
            }
        }
    }
}