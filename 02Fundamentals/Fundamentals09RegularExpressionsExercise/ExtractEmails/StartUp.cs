namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            string emailFormat = @"^[A-Za-z]+[_.-]*?[A-Za-z]+[_.-]*?[A-Za-z]+@[A-Za-z]+-?[A-Za-z]+\.[A-Za-z]+-?[A-Za-z]+(\.[A-Za-z]+-?[A-Za-z]+)?";
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var thing in input)
            {
                Match match = Regex.Match(thing, emailFormat);
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}