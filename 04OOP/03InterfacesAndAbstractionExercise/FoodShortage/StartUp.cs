namespace FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            List<IBuyer> entries = new List<IBuyer>();

            for (int i = 0; i < people; i++)
            {
                string[] entry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (entry.Length == 3)
                {
                    entries.Add(new Rebel(entry[0], int.Parse(entry[1]), entry[2]));
                }
                else if (entry.Length == 4)
                {
                    entries.Add(new Citizen(entry[0], int.Parse(entry[1]), entry[2], entry[3]));
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                entries.FirstOrDefault(x => x.Name == command)?.BuyFood();
            }

            Console.WriteLine(entries.Sum(entry => entry.Food));
        }
    }
}