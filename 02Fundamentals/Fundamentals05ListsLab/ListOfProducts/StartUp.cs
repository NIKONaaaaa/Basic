namespace ListOfProducts
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            ListProducts(int.Parse(Console.ReadLine()));
            static void ListProducts(int counter)
            {
                List<string> products = new List<string>();
                for (int i = 0; i < counter; i++)
                {
                    products.Add(Console.ReadLine());
                }
                products.Sort();
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine($"{i + 1}.{products[i]}");
                }
            }
        }
    }
}