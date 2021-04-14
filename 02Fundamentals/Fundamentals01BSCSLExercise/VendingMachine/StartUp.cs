namespace VendingMachine
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double sum = 0;
            string[] products = { "Nuts", "Water", "Crisps", "Soda", "Coke" };
            double[] prices = { 2, 0.7, 1.5, 0.8, 1 }, coins = { 0.1, 0.2, 0.5, 1, 2 };
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                else if (Array.IndexOf(coins, double.Parse(input)) < 0)
                {
                    Console.WriteLine($"Cannot accept {double.Parse(input)}");
                }
                else
                {
                    sum += double.Parse(input);
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine($"Change: {sum:f2}");
                    break;
                }
                else if (Array.IndexOf(products, input) < 0)
                {
                    Console.WriteLine("Invalid product");
                }
                else if (sum < prices[Array.IndexOf(products, input)])
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    sum -= prices[Array.IndexOf(products, input)];
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
            }
        }
    }
}