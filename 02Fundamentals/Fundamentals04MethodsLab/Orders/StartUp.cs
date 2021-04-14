namespace Orders
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int productAmount = int.Parse(Console.ReadLine());
            PriceCalc(product, productAmount);
            static void PriceCalc(string product, int productAmount)
            {
                string[] products = { "coffee", "water", "coke", "snacks" };
                double[] prices = { 1.5, 1, 1.4, 2 };
                int productIndex = Array.IndexOf(products, product);
                Console.WriteLine($"{prices[productIndex] * productAmount:f2}");
            }
        }
    }
}