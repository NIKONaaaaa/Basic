namespace SmallShop
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine().ToLower();
            string cityName = Console.ReadLine().ToLower();
            double productAmount = double.Parse(Console.ReadLine());
            double productPrice = 0;
            switch (cityName)
            {
                case "sofia":
                    switch (productName)
                    {
                        case "coffee":
                            productPrice = 0.5;
                            break;
                        case "water":
                            productPrice = 0.8;
                            break;
                        case "beer":
                            productPrice = 1.2;
                            break;
                        case "sweets":
                            productPrice = 1.45;
                            break;
                        case "peanuts":
                            productPrice = 1.6;
                            break;
                    }
                    break;
                case "plovdiv":
                    switch (productName)
                    {
                        case "coffee":
                            productPrice = 0.4;
                            break;
                        case "water":
                            productPrice = 0.7;
                            break;
                        case "beer":
                            productPrice = 1.15;
                            break;
                        case "sweets":
                            productPrice = 1.3;
                            break;
                        case "peanuts":
                            productPrice = 1.5;
                            break;
                    }
                    break;
                case "varna":
                    switch (productName)
                    {
                        case "coffee":
                            productPrice = 0.45;
                            break;
                        case "water":
                            productPrice = 0.7;
                            break;
                        case "beer":
                            productPrice = 1.1;
                            break;
                        case "sweets":
                            productPrice = 1.35;
                            break;
                        case "peanuts":
                            productPrice = 1.55;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"{productAmount * productPrice}");
        }
    }
}