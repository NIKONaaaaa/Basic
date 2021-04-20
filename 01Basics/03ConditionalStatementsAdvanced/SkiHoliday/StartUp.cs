namespace SkiTrip
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int vacationDays = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine().ToLower();
            string feedBack = Console.ReadLine().ToLower();
            double vacationCost = 0;
            double vacationDiscount = 1;
            double tipAmount = 1;
            if (vacationDays < 10)
            {
                switch (roomType)
                {
                    case "apartment":
                        vacationDiscount = 0.7;
                        break;
                    case "president apartment":
                        vacationDiscount = 0.9;
                        break;
                    default:
                        vacationDiscount = 1;
                        break;
                }
            }
            else if (10 <= vacationDays && vacationDays <= 15)
            {
                switch (roomType)
                {
                    case "apartment":
                        vacationDiscount = 0.65;
                        break;
                    case "president apartment":
                        vacationDiscount = 0.85;
                        break;
                    default:
                        vacationDiscount = 1;
                        break;
                }
            }
            else
            {
                switch (roomType)
                {
                    case "apartment":
                        vacationDiscount = 0.5;
                        break;
                    case "president apartment":
                        vacationDiscount = 0.8;
                        break;
                    default:
                        vacationDiscount = 1;
                        break;
                }
            }
            switch (feedBack)
            {
                case "positive":
                    tipAmount = 1.25;
                    break;
                case "negative":
                    tipAmount = 0.9;
                    break;
            }
            switch (roomType)
            {
                case "room for one person":
                    vacationCost = 18 * (vacationDays - 1) * vacationDiscount * tipAmount;
                    break;
                case "apartment":
                    vacationCost = 25 * (vacationDays - 1) * vacationDiscount * tipAmount;
                    break;
                case "president apartment":
                    vacationCost = 35 * (vacationDays - 1) * vacationDiscount * tipAmount;
                    break;
            }
            Console.WriteLine($"{vacationCost:f2}");
        }
    }
}