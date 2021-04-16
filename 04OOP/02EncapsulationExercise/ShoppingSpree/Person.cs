namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Person
    {
        private string name;
        private int money;
        private List<Product> productBag;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }
        public int Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public List<Product> ProductBag
        {
            get => this.productBag;
            private set => this.productBag = this.ProductBag;
        }

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.productBag = new List<Product>();
        }

        public void Buy(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException($"{Name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;
            this.ProductBag.Add(product);
            Console.WriteLine($"{this.Name} bought {product.Name}");

        }

        public override string ToString()
        {
            return this.ProductBag.Count == 0 ? $"{this.Name} - Nothing bought" : $"{this.Name} - {string.Join(", ", this.ProductBag.Select(item => item.Name))}";
        }
    }
}