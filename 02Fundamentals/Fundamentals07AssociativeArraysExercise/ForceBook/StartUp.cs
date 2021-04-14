namespace ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            SortedDictionary<string, List<string>> forceBook = new SortedDictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] commandInput = command.Split(" | ");
                    if (forceBook.ContainsKey(commandInput[0]) && !UserExists(forceBook, commandInput[1]))
                    {
                        forceBook[commandInput[0]].Add(commandInput[1]);
                    }
                    else if (!UserExists(forceBook, commandInput[1]))
                    {
                        forceBook.Add(commandInput[0], new List<string> { commandInput[1] });
                    }
                }
                else if (command.Contains("->"))
                {
                    string[] commandInput = command.Split(" -> ");
                    foreach (var forceSide in forceBook.Where(side => side.Value.Contains(commandInput[0])))
                    {
                        forceBook[forceSide.Key].Remove(commandInput[0]);
                    }
                    if (forceBook.ContainsKey(commandInput[1]))
                    {
                        forceBook[commandInput[1]].Add(commandInput[0]);
                    }
                    else
                    {
                        forceBook.Add(commandInput[1], new List<string> { commandInput[0] });
                    }
                    Console.WriteLine($"{commandInput[0]} joins the {commandInput[1]} side!");
                }
                command = Console.ReadLine();
            }
            foreach (var forceSide in forceBook.OrderByDescending(userCount => userCount.Value.Count).Where(userCount => 0 < userCount.Value.Count))
            {
                Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count}");
                foreach (var user in forceSide.Value.OrderBy(name => name))
                {
                    Console.WriteLine(string.Join(Environment.NewLine, $"! {user}"));
                }
            }
        }
        private static bool UserExists(SortedDictionary<string, List<string>> forceBook, string userName)
        {
            foreach (var forceSide in forceBook.Where(side => side.Value.Contains(userName)))
            {
                return true;
            }
            return false;
        }
    }
}