namespace ListOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> numbersInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandInput = Console.ReadLine().Split();
            while (commandInput[0].ToLower() != "end")
            {
                if (commandInput[0].ToLower() == "add")
                {
                    numbersInput.Add(int.Parse(commandInput[1]));
                }
                if (commandInput[0].ToLower() == "insert")
                {
                    if (0 > int.Parse(commandInput[2]) || int.Parse(commandInput[2]) >= numbersInput.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbersInput.Insert(int.Parse(commandInput[2]), int.Parse(commandInput[1]));
                    }
                }
                if (commandInput[0].ToLower() == "remove")
                {
                    if (0 > int.Parse(commandInput[1]) || int.Parse(commandInput[1]) >= numbersInput.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbersInput.RemoveAt(int.Parse(commandInput[1]));
                    }
                }
                if (commandInput[0].ToLower() == "shift")
                {
                    if (commandInput[1].ToLower() == "left")
                    {
                        for (int i = 1; i <= int.Parse(commandInput[2]); i++)
                        {
                            numbersInput.Add(numbersInput[0]);
                            numbersInput.Remove(numbersInput[0]);
                        }
                    }
                    else if (commandInput[1].ToLower() == "right")
                    {
                        for (int i = 1; i <= int.Parse(commandInput[2]); i++)
                        {
                            numbersInput.Insert(0, numbersInput[^1]);
                            numbersInput.RemoveAt(numbersInput.Count - 1);
                        }
                    }
                }
                commandInput = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbersInput));
        }
    }
}