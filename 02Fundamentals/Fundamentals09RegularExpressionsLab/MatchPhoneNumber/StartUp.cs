namespace MatchPhoneNumber
{
using System;
using System.Linq;
using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            string validPhone = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string phones = Console.ReadLine();
            MatchCollection matches = Regex.Matches(phones, validPhone);
            string[] matchedPhone = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhone));
        }
    }
}