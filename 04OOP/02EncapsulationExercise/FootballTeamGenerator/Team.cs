namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Team
    {
        private string name;
        private readonly Dictionary<string, Player> players;

        public Team(string name)
        {
            Name = name;
            players = new Dictionary<string, Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                Names.Validate(value);

                name = value;
            }
        }

        public int Rating
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }

                return (int)Math.Round(players.Values.Average(x => x.AverageStats), 0);
            }
        }

        public void AddPlayer(Player player)
        {
            if (players.ContainsKey(player.Name))
            {
                throw new ArgumentException($"Player {player.Name} already exists!");
            }

            players.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!players.ContainsKey(playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");
            }

            players.Remove(playerName);
        }
    }
}