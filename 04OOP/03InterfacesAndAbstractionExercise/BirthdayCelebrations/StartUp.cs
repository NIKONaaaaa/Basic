namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            string command;
            List<IBiological> entries = new List<IBiological>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] entity = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (entity[0] == "Pet")
                {
                    entries.Add(new Pet(entity[1], entity[2]));
                }
                else if (entity[0] == "Citizen")
                {
                    entries.Add(new Citizen(entity[1], int.Parse(entity[2]), entity[3], entity[4]));
                }
            }

            string year = Console.ReadLine();

            foreach (var entry in entries.Where(entry => entry.GetBirthYear() == year))
            {
                Console.WriteLine(entry.Birthdate);
            }
        }
    }
}