namespace Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Product> productList = new Dictionary<string, Product>();
            string[] commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commandInput[0] != "buy")
            {
                string itemName = commandInput[0];
                int itemAmount = int.Parse(commandInput[2]);
                double itemPrice = double.Parse(commandInput[1]);
                Product product = new Product(itemAmount, itemPrice);
                if (productList.ContainsKey(itemName))
                {
                    productList[itemName].Price = itemPrice;
                    productList[itemName].Quantity += itemAmount;
                }
                else
                {
                    productList.Add(itemName, product);
                }
                commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var item in productList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.TotalPrice():f2}");
            }
        }
    }
    public class Product
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
        internal double TotalPrice()
        {
            return Price * Quantity;
        }
    }
}