namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> keyMaterials = new Dictionary<string, string>() { { "shards", "Shadowmourne" }, { "fragments", "Valanyr" }, { "motes", "Dragonwrath" } };
            SortedDictionary<string, int> resources = new SortedDictionary<string, int> { { "shards", 0 }, { "fragments", 0 }, { "motes", 0 } };
            bool legendaryAchieved = false;
            while (!legendaryAchieved)
            {
                string[] commandInput = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < commandInput.Length; i += 2)
                {
                    string resource = commandInput[i + 1];
                    int resourceQuantity = int.Parse(commandInput[i]);
                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += resourceQuantity;
                    }
                    else
                    {
                        resources.Add(resource, resourceQuantity);
                    }
                    if (keyMaterials.ContainsKey(resource) && !(resources[resource] < 250))
                    {
                        legendaryAchieved = true;
                        resources[resource] -= 250;
                        Console.WriteLine($"{keyMaterials[resource]} obtained!");
                        break;
                    }
                }
            }
            foreach (var entry in resources.Where(material => keyMaterials.ContainsKey(material.Key)).OrderByDescending(quantity => quantity.Value))
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            foreach (var entry in resources.Where(material => !keyMaterials.ContainsKey(material.Key)))
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}