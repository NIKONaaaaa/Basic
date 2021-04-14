namespace AMinerTask
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string commandInput = Console.ReadLine();
            while (commandInput != "stop")
            {
                string resource = commandInput;
                int resourceQuantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += resourceQuantity;
                }
                else
                {
                    resources.Add(resource, resourceQuantity);
                }
                commandInput = Console.ReadLine();
            }
            foreach (var entry in resources)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}