namespace FootballTeamGenerator
{
    using Validators;
    public class PlayerStatList
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double average;

        public PlayerStatList(int[] stats)
        {
            Endurance = stats[0];
            Sprint = stats[1];
            Dribble = stats[2];
            Passing = stats[3];
            Shooting = stats[4];
            Average = 0;
        }

        public int Endurance
        {
            get => endurance;
            private set
            {
                Stats.Validate("Endurance", value);

                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            private set
            {
                Stats.Validate("Sprint", value);

                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                Stats.Validate("Dribble", value);

                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            private set
            {
                Stats.Validate("Passing", value);

                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                Stats.Validate("Shooting", value);

                shooting = value;
            }
        }

        public double Average
        {
            get => average;
            set
            {
                value = (dribble + endurance + passing + shooting + sprint) / 5.00;
                average = value;
            }
        }
    }
}