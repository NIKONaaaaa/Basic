namespace CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> info = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string continent = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                string country = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
                string city = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2];
                if (!info.ContainsKey(continent))
                {
                    info.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!info[continent].ContainsKey(country))
                {
                    info[continent].Add(country, new List<string>());
                }
                info[continent][country].Add(city);
            }
            foreach (var (continent, country) in info)
            {
                Console.WriteLine($"{continent}:");
                foreach (var (countryName, cities) in country)
                {
                    Console.WriteLine($"{countryName} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}