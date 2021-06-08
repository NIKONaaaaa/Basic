namespace FootballTeamGenerator
{
    public class PlayerStatList
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double average;

        public int Endurance
        {
            get => endurance;
            private set
            {
                StatValidator.ValidateStat(value, "Endurance");

                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            private set
            {
                StatValidator.ValidateStat(value, "Sprint");

                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                StatValidator.ValidateStat(value, "Dribble");

                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            private set
            {
                StatValidator.ValidateStat(value, "Passing");

                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                StatValidator.ValidateStat(value, "Shooting");

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

        public PlayerStatList(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            Average = 0;
        }
    }
}