namespace FootballTeamGenerator
{
    using System;
    public class StatValidator
    {
        private const int MaxStat = 100;

        public static void ValidateStat(int value, string stat)
        {
            if (0 > value || value > MaxStat)
            {
                throw new ArgumentException($"{stat} should be between 0 and {MaxStat}.");
            }
        }
    }
}