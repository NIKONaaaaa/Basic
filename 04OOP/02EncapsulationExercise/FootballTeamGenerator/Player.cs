namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private readonly PlayerStatList stats;

        public double AverageStats => stats.Average;
        public Player(string name, PlayerStatList stats)
        {
            Name = name;
            this.stats = stats;
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
    }
}