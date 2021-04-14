namespace Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string colour = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }
                foreach (string item in clothes)
                {
                    if (wardrobe[colour].ContainsKey(item))
                    {
                        wardrobe[colour][item]++;
                    }
                    else
                    {
                        wardrobe[colour].Add(item, 1);
                    }
                }
            }
            string[] lookFor = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var (colour, item) in wardrobe)
            {
                Console.WriteLine($"{colour} clothes:");
                foreach (var (clothing, quantity) in item)
                {
                    Console.Write($"* {clothing} - {quantity}");
                    if (colour == lookFor[0] && clothing == lookFor[1])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}