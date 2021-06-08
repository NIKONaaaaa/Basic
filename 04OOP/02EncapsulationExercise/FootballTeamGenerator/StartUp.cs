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
                            int endurance = int.Parse(splitInput[3]);
                            int sprint = int.Parse(splitInput[4]);
                            int dribble = int.Parse(splitInput[5]);
                            int passing = int.Parse(splitInput[6]);
                            int shooting = int.Parse(splitInput[7]);
                            teams[teamName].AddPlayer(new Player(playerName, new PlayerStatList(endurance, sprint, dribble, passing, shooting)));
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