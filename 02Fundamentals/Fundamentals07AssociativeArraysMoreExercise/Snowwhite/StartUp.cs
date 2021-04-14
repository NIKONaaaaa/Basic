namespace Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, int> dwarves = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string dwarfNameAndHatColour = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)[0] + " " + input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)[1];
                int dwarfPhysics = int.Parse(input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)[2]);
                if (dwarves.ContainsKey(dwarfNameAndHatColour))
                {
                    if (dwarves[dwarfNameAndHatColour] < dwarfPhysics)
                    {
                        dwarves[dwarfNameAndHatColour] = dwarfPhysics;
                    }
                }
                else
                {
                    dwarves.Add(dwarfNameAndHatColour, dwarfPhysics);
                }
                input = Console.ReadLine();
            }
            foreach (var item in dwarves.OrderByDescending(physics => physics.Value).ThenByDescending(x => dwarves.Count(y => y.Key.Split()[1] == x.Key.Split()[1])))
            {
                Console.WriteLine($"({item.Key.Split()[1]}) {item.Key.Split()[0]} <-> {item.Value}");
            }
        }
    }
}