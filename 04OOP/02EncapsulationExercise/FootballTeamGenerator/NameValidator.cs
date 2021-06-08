namespace FootballTeamGenerator
{
    using System;
    public class NameValidator
    {
        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("A name should not be empty.");
            }
        }
    }
}