namespace StoreBoxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<Box> inventory = new List<Box>();
            string[] commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commandInput[0] != "end")
            {
                inventory.Add(new Box(commandInput[0], int.Parse(commandInput[2]), commandInput[1], decimal.Parse(commandInput[3])));
                commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (Box box in inventory.OrderByDescending(box => box.BoxPrice))
            {
                Console.Write($"{box.SerialNumber}\n-- {box.Product.Name} - ${box.Product.Price:f2}: {box.Quantity}\n-- ${box.BoxPrice:f2}\n");
            }
        }
    }
    class Box
    {
        internal class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
        }
        public string SerialNumber { get; set; }
        public Item Product { get; set; }
        public int Quantity { get; set; }
        public decimal BoxPrice { get; set; }
        public Box(string serialNumber, int quantity, string productName, decimal productPrice)
        {
            SerialNumber = serialNumber;
            Product = new Item(productName, productPrice);
            Quantity = quantity;
            BoxPrice = Product.Price * Quantity;
        }
    }
}