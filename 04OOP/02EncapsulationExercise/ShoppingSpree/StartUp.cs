namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            string peopleInput = Console.ReadLine();
            string productInput = Console.ReadLine();
            List<string> peopleIntermediate = peopleInput.Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> productsIntermediate = productInput.Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
                foreach (string person in peopleIntermediate)
                {
                    string personName = person.Split("=")[0];
                    int personMoney = int.Parse(person.Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);
                    Person newPerson = new Person(personName, personMoney);
                    people.Add(newPerson);
                }

                foreach (string product in productsIntermediate)
                {
                    string productName = product.Split("=")[0];
                    int productCost = int.Parse(product.Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);
                    Product newProduct = new Product(productName, productCost);
                    products.Add(newProduct);
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                try
                {
                    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string personName = tokens[0];
                    string productName = tokens[1];
                    Product product = products.FirstOrDefault(prod => prod.Name == productName);
                    people.FirstOrDefault(pers => pers.Name == personName).Buy(product);
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}