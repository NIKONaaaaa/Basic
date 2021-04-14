namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries), products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> personList = new List<Person>();
            foreach (string person in people)
            {
                personList.Add(new Person(person.Split("=")[0], double.Parse(person.Split("=")[1])));
            }
            List<Product> productList = new List<Product>();
            foreach (string product in products)
            {
                productList.Add(new Product(product.Split("=")[0], double.Parse(product.Split("=")[1])));
            }
            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                string name = command[0];
                string product = command[1];
                Person currPerson = personList.FirstOrDefault(n => n.Name == name);
                Product currProduct = productList.FirstOrDefault(p => p.ProductName == product);
                if (currPerson.HasEnoughMoney(currProduct))
                {
                    currPerson.BuyProduct(currProduct);
                    Console.WriteLine($"{name} bought {product}");
                }
                else
                {
                    Console.WriteLine($"{name} can't afford {product}");
                }
                command = Console.ReadLine().Split();
            }
            foreach (var person in personList)
            {
                Console.WriteLine(person);
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; }
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }
        public void BuyProduct(Product product)
        {
            Products.Add(product);
            Money -= product.Price;
        }
        internal bool HasEnoughMoney(Product product)
        {
            if (Money >= product.Price)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            if (Products.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            return $"{Name} - {string.Join(", ", Products)}";
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            ProductName = name;
            Price = price;
        }
        public override string ToString()
        {
            return ProductName;
        }
    }
}