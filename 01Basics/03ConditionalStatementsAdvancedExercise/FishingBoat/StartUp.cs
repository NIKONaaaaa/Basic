namespace FishingBoat
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            int fishermen = int.Parse(Console.ReadLine());
            double boatPrice = 2600;
            double discountOne = 1;
            double discountTwo = 1;
            bool check = true;
            if (6 >= fishermen)
            {
                discountOne = 0.9;
            }
            else if (7 <= fishermen && fishermen <= 11)
            {
                discountOne = 0.85;
            }
            else
            {
                discountOne = 0.75;
            }
            switch (season)
            {
                case "spring":
                    boatPrice = 3000;
                    break;
                case "summer":
                    boatPrice = 4200;
                    break;
                case "autumn":
                    boatPrice = 4200;
                    check = false;
                    break;
            } 
            if (fishermen % 2 == 0 && check == true)
            {
                discountTwo = 0.95;
            }
            double totalPrice = boatPrice * discountOne * discountTwo;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}