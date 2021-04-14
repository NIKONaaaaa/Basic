namespace ListManipulationAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            ListManipulation(Console.ReadLine().Split().Select(int.Parse).ToList());
            static void ListManipulation(List<int> numbersInput)
            {
                bool basicOperationPerformed = false;
                string[] commandInput = Console.ReadLine().Split();
                while (commandInput[0] != "end")
                {
                    switch (commandInput[0])
                    {
                        case "Add":
                            numbersInput.Add(int.Parse(commandInput[1]));
                            basicOperationPerformed = true;
                            break;
                        case "Remove":
                            numbersInput.Remove(int.Parse(commandInput[1]));
                            basicOperationPerformed = true;
                            break;
                        case "RemoveAt":
                            numbersInput.RemoveAt(int.Parse(commandInput[1]));
                            basicOperationPerformed = true;
                            break;
                        case "Insert":
                            numbersInput.Insert(int.Parse(commandInput[2]), int.Parse(commandInput[1]));
                            basicOperationPerformed = true;
                            break;
                        case "Contains":
                            if (numbersInput.Contains(int.Parse(commandInput[1]))) Console.WriteLine("Yes");
                            else Console.WriteLine("No such number");
                            break;
                        case "PrintEven":
                            Console.WriteLine(string.Join(" ", numbersInput.FindAll(x => x % 2 == 0)));
                            break;
                        case "PrintOdd":
                            Console.WriteLine(string.Join(" ", numbersInput.FindAll(x => x % 2 == 1)));
                            break;
                        case "GetSum":
                            Console.WriteLine(numbersInput.Sum());
                            break;
                        case "Filter":
                            if (commandInput[1] == "<") Console.WriteLine(string.Join(" ", numbersInput.FindAll(x => x < int.Parse(commandInput[2]))));
                            else if (commandInput[1] == ">") Console.WriteLine(string.Join(" ", numbersInput.FindAll(x => x > int.Parse(commandInput[2]))));
                            else if (commandInput[1] == "<=") Console.WriteLine(string.Join(" ", numbersInput.FindAll(x => x <= int.Parse(commandInput[2]))));
                            else if (commandInput[1] == ">=") Console.WriteLine(string.Join(" ", numbersInput.FindAll(x => x >= int.Parse(commandInput[2]))));
                            break;
                    }
                    commandInput = Console.ReadLine().Split();
                }
                if (basicOperationPerformed) Console.WriteLine(string.Join(" ", numbersInput));
            }
        }
    }
}