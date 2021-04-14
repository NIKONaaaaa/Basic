namespace SoftUniBarIncome
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            const string inputFormat = @"%(?<customerName>[A-Z][a-z]+)%(?:[^%$|.]+)?<(?<productName>\w+)>(?:[^%$|.]+)?\|(?<quantity>\d+)\|(?:[^%$|.\d]+)?(?<price>\d+\.?\d+)\$";
            string input = Console.ReadLine(), collection = "";
            decimal totalIncome = 0;
            while (input != "end of shift")
            {
                collection += ($"{input} ");
                input = Console.ReadLine();
            }
            MatchCollection purchaseInfo = Regex.Matches(collection, inputFormat);
            foreach (Match customer in purchaseInfo)
            {
                Console.WriteLine($"{customer.Groups["customerName"].Value}: {customer.Groups["productName"]} - {int.Parse(customer.Groups["quantity"].Value) * decimal.Parse(customer.Groups["price"].Value):f2}");
                totalIncome += int.Parse(customer.Groups["quantity"].Value) * decimal.Parse(customer.Groups["price"].Value);
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}