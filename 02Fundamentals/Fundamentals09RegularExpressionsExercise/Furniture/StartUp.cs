namespace Furniture
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine(), inputFormat = @"\B>>(?<name>[a-zA-Z]+)<<(?<price>(?:\d+)|(?:\d+.\d+))!(?<quantity>\d+)\b", collection = "";
            decimal moneySpent = 0;
            while (input != "Purchase")
            {
                collection += ($"{input} ");
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            MatchCollection matches = Regex.Matches(collection, inputFormat);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["name"].Value);
                moneySpent += decimal.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value);
            }
            Console.WriteLine($"Total money spend: {moneySpent:f2}");
        }
    }
}