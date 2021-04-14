namespace ThePartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, List<string>> activeFilters = new Dictionary<string, List<string>>();
            static bool FilterFunction(string person, string criteria, string filter) =>
                criteria == "Starts with" && person.StartsWith(filter) ||
                criteria == "Ends with" && person.EndsWith(filter) ||
                criteria == "Length" && person.Length == int.Parse(filter) ||
                criteria == "Contains" && person.Contains(filter);
            string command = Console.ReadLine();
            while (command != "Print")
            {
                string[] token = command.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (token[0] == "Add filter")
                {
                    if (!activeFilters.ContainsKey(token[1]))
                    {
                        activeFilters.Add(token[1], new List<string>());
                    }
                    activeFilters[token[1]].Add(token[2]);
                }
                else
                {
                    activeFilters.Remove(token[1]);
                }
                command = Console.ReadLine();
            }
            foreach (var (filterType, filterCriteria) in activeFilters)
            {
                foreach (string criteria in filterCriteria)
                {
                    names = names.Where(person => !FilterFunction(person, filterType, criteria)).ToList();
                }
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}