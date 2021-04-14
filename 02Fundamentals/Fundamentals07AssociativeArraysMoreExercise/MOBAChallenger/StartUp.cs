namespace MOBAChallenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "Season end")
            {
                if (input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length == 3)
                {
                    string playerOne = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                    string playerTwo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2];
                    if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
                    {
                        foreach (string position in players[playerOne].Keys)
                        {
                            if (players[playerTwo].ContainsKey(position))
                            {
                                if (players[playerOne].Values.Sum() < players[playerTwo].Values.Sum())
                                {
                                    players.Remove(playerOne);
                                    break;
                                }
                                if (players[playerOne].Values.Sum() > players[playerTwo].Values.Sum())
                                {
                                    players.Remove(playerTwo);
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length > 3)
                {
                    string playerName = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[0];
                    string playerPosition = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int playerSkill = int.Parse(input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    if (players.ContainsKey(playerName))
                    {
                        if (players[playerName].ContainsKey(playerPosition))
                        {
                            if (players[playerName][playerPosition] < playerSkill)
                            {
                                players[playerName][playerPosition] = playerSkill;
                            }
                        }
                        else
                        {
                            players[playerName].Add(playerPosition, playerSkill);
                        }
                    }
                    else
                    {
                        players.Add(playerName, new Dictionary<string, int> { { playerPosition, playerSkill } });
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var (player, stats) in players.OrderByDescending(points => points.Value.Values.Sum()).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{player}: {players[player].Values.Sum()} skill");
                foreach (var (position, skill) in stats.OrderByDescending(points => points.Value).ThenBy(name => name.Key))
                {
                    Console.WriteLine($"- {position} <::> {skill}");
                }
            }
        }
    }
}