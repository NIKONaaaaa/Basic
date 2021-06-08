namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitInput = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string command = splitInput[0];
                string teamName = splitInput[1];
                try
                {
                    switch (command)
                    {
                        case "Team" when !teams.ContainsKey(teamName):
                            teams.Add(teamName, new Team(teamName));
                            break;
                        case "Add" when teams.ContainsKey(teamName):
                            string playerName = splitInput[2];
                            int[] statValues = new int[5];
                            for (int inputIndex = 3, statIndex = 0; inputIndex <= 7; inputIndex++, statIndex++)
                            {
                                statValues[statIndex] = (int.Parse(splitInput[inputIndex]));
                            }
                            teams[teamName].AddPlayer(new Player(playerName, new PlayerStatList(statValues)));
                            break;
                        case "Remove" when teams.ContainsKey(teamName):
                            playerName = splitInput[2];
                            teams[teamName].RemovePlayer(playerName);
                            break;
                        case "Rating" when teams.ContainsKey(teamName):
                            Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                            break;
                        default:
                            throw new ArgumentException($"Team {teamName} does not exist.");
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}