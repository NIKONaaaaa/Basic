namespace ProductShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();
            while (command != "Revision")
            {
                string shopName = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
                string productName = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];
                double productPrice = double.Parse(command.Split(", ", StringSplitOptions.RemoveEmptyEntries)[2]);
                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }
                shops[shopName].Add(productName, productPrice);
                command = Console.ReadLine();
            }
            foreach (var (shop, product) in shops)
            {
                Console.WriteLine($"{shop}->");
                foreach (var (name, price) in product)
                {
                    Console.WriteLine($"Product: {name}, Price: {price}");
                }
            }
        }
    }
}