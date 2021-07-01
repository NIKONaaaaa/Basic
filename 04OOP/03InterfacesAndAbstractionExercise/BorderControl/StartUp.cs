namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        public static void Main()
        {
            string command;
            List<IIdentifiable> entries = new List<IIdentifiable>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] entity = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (entity.Length == 2)
                {
                    entries.Add(new Robot(entity[0], entity[1]));
                }
                else if (entity.Length == 3)
                {
                    entries.Add(new Citizen(entity[0], int.Parse(entity[1]), entity[2]));
                }
            }

            string checkId = Console.ReadLine();

            foreach (var entry in entries.Where(entry => entry.Id.EndsWith(checkId)))
            {
                Console.WriteLine(entry.Id);
            }
        }
    }
}