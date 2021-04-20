namespace FruitShop
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine().ToLower();
            string weekDay = Console.ReadLine().ToLower();
            double productAmount = double.Parse(Console.ReadLine());
            double productPrice = 0;
            bool check = true;
            switch (weekDay)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    switch (productName)
                    {
                        case "banana":
                            productPrice = 2.5;
                            break;
                        case "apple":
                            productPrice = 1.2;
                            break;
                        case "orange":
                            productPrice = 0.85;
                            break;
                        case "grapefruit":
                            productPrice = 1.45;
                            break;
                        case "kiwi":
                            productPrice = 2.7;
                            break;
                        case "pineapple":
                            productPrice = 5.5;
                            break;
                        case "grapes":
                            productPrice = 3.85;
                            break;
                        default:
                            check = false;
                            break;
                    }
                    break;
                case "saturday":
                case "sunday":
                    switch (productName)
                    {
                        case "banana":
                            productPrice = 2.7;
                            break;
                        case "apple":
                            productPrice = 1.25;
                            break;
                        case "orange":
                            productPrice = 0.9;
                            break;
                        case "grapefruit":
                            productPrice = 1.6;
                            break;
                        case "kiwi":
                            productPrice = 3;
                            break;
                        case "pineapple":
                            productPrice = 5.6;
                            break;
                        case "grapes":
                            productPrice = 4.2;
                            break;
                        default:
                            check = false;
                            break;
                    }
                    break;
                default:
                    check = false;
                    break;
            }
            if (check == false)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{productAmount * productPrice:f2}");
            }
        }
    }
}