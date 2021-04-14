namespace PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            StringBuilder partyGoers = new StringBuilder();
            static bool FilterFunction(string person, string criteria, string filter) =>
                criteria == "StartsWith" && person.StartsWith(filter) ||
                criteria == "EndsWith" && person.EndsWith(filter) ||
                criteria == "Length" && person.Length == int.Parse(filter);
            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (token[0] == "Remove")
                {
                    names = names.Where(person => !FilterFunction(person, token[1], token[2])).ToList();
                }
                else
                {
                    List<string> doubleNames = names.Where(person => FilterFunction(person, token[1], token[2])).ToList();
                    foreach (string person in doubleNames)
                    {
                        names.Insert(names.IndexOf(person), person);
                    }
                }
                command = Console.ReadLine();
            }
            partyGoers.Append(names.Count == 0 ? "Nobody is" : $"{string.Join(", ", names)} are");
            partyGoers.Append(" going to the party!");
            Console.WriteLine(partyGoers);
        }
    }
}