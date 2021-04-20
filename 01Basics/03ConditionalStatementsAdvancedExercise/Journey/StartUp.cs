namespace Journey
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string vacationLocation = "Europe";
            string vacationType = "Hotel";
            double spending = 0.9;
            if (100 < budget && budget <= 1000)
            {
                vacationLocation = "Balkans";
                switch (season)
                {
                    case "summer":
                        vacationType = "Camp";
                        spending = 0.4;
                        break;
                    case "winter":
                        vacationType = "Hotel";
                        spending = 0.8;
                        break;
                }

            }
            else if (budget <= 100)
            {
                vacationLocation = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        vacationType = "Camp";
                        spending = 0.3;
                        break;
                    case "winter":
                        vacationType = "Hotel";
                        spending = 0.7;
                        break;
                }
            }
            Console.WriteLine($"Somewhere in {vacationLocation}");
            Console.WriteLine($"{vacationType} - {budget * spending:f2}");
        }
    }
}