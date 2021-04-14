namespace MatchDates
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            Regex dateFormat = new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            string dates = Console.ReadLine();
            MatchCollection validDates = dateFormat.Matches(dates);
            foreach (Match date in validDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}