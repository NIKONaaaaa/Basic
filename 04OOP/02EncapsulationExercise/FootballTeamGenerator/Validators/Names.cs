namespace FootballTeamGenerator.Validators
{
    using System;
    public class Names
    {
        public static void Validate(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("A name should not be empty.");
            }
        }
    }
}