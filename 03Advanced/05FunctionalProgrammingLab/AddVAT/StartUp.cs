namespace AddVAT
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            static double AddVat(string price) => double.Parse(price) * 1.2;
            double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(AddVat).ToArray();
            foreach (double price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}