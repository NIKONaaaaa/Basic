namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int commandCounter = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkeeList = new Dictionary<string, string>();
            for (int i = 1; i <= commandCounter; i++)
            {
                string[] commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string parkeeName = commandInput[1];
                if (commandInput[0] == "register")
                {
                    string parkeePlate = commandInput[2];
                    if (parkeeList.ContainsKey(parkeeName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkeeList[parkeeName]}");
                    }
                    else
                    {
                        parkeeList.Add(parkeeName, parkeePlate);
                        Console.WriteLine($"{parkeeName} registered {parkeeList[parkeeName]} successfully");
                    }
                }
                else
                {
                    if (parkeeList.ContainsKey(parkeeName))
                    {
                        parkeeList.Remove(parkeeName);
                        Console.WriteLine($"{parkeeName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {parkeeName} not found");
                    }
                }
            }
            foreach (KeyValuePair<string, string> parkee in parkeeList)
            {
                Console.WriteLine($"{parkee.Key} => {parkee.Value}");
            }
        }
    }
}