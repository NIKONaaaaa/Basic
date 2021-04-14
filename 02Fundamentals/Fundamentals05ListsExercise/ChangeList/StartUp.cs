namespace ChangeList
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
            while (commandInput[0] != "end")
            {
                if (commandInput[0] == "Delete")
                {
                    numbersInput.RemoveAll(x => x == int.Parse(commandInput[1]));
                }
                else if (commandInput[0] == "Insert")
                {
                    numbersInput.Insert(int.Parse(commandInput[2]), int.Parse(commandInput[1]));
                }
                commandInput = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbersInput));
        }
    }
}