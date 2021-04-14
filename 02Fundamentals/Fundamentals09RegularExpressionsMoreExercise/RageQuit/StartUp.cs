namespace RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder output = new StringBuilder();
            MatchCollection matches = Regex.Matches(input, @"(\D+)(\d{1,})");
            foreach (Match match in matches)
            {
                output.Append(String.Concat(Enumerable.Repeat(match.Groups[1].Value, int.Parse(match.Groups[2].Value))));
            }
            Console.WriteLine($"Unique symbols used: {output.ToString().Distinct().Count()}\n{output}");
        }
    }
}