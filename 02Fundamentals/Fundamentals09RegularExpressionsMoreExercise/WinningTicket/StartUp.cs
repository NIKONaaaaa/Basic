namespace WinningTicket
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            string[] tickets = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(element => element.Trim()).ToArray();
            string winningPattern = @"(([@#$^])\2{5,9})";
            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string matchOne = Regex.Match(ticket.Substring(0, 10), winningPattern).Groups[1].ToString();
                    string matchTwo = Regex.Match(ticket.Substring(10, 10), winningPattern).Groups[1].ToString();
                    matchOne = matchOne.Substring(0, Math.Min(matchOne.Length, matchTwo.Length));
                    matchTwo = matchTwo.Substring(0, Math.Min(matchOne.Length, matchTwo.Length));
                    StringBuilder result = new StringBuilder($"ticket \"{ticket}\" - ");
                    if (matchOne == matchTwo && matchOne != "")
                    {
                        result.Append($"{matchOne.Length}{matchOne.Substring(0, 1)}");
                        if (matchOne.Length == 10)
                        {
                            result.Append(" Jackpot!");
                        }
                    }
                    else
                    {
                        result.Append("no match");
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}