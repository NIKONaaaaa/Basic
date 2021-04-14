namespace HouseParty
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            int commandCounter = int.Parse(Console.ReadLine());
            List<string> listOfPartyGuests = new List<string>();
            for (int i = 1; i <= commandCounter; i++)
            {
                string[] commandInput = Console.ReadLine().Split();
                if (commandInput[2] == "going!")
                {
                    if (listOfPartyGuests.Contains(commandInput[0]))
                    {
                        Console.WriteLine($"{commandInput[0]} is already in the list!");
                    }
                    else
                    {
                        listOfPartyGuests.Add(commandInput[0]);
                    }
                }
                else
                {
                    if (listOfPartyGuests.Contains(commandInput[0]))
                    {
                        listOfPartyGuests.Remove(commandInput[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commandInput[0]} is not in the list!");
                    }
                }
            }
            foreach (string person in listOfPartyGuests)
            {
                Console.WriteLine(person);
            }
        }
    }
}