namespace FootballTeamGenerator.Validators
{
    using System;
    public class Stats
    {
        private const int MaxStat = 100;

        public static void Validate(string stat, int value)
        {
            if (0 > value || value > MaxStat)
            {
                throw new ArgumentException($"{stat} should be between 0 and {MaxStat}.");
            }
        }
    }
}