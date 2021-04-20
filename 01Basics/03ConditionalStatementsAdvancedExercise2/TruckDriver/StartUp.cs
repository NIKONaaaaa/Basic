namespace TruckDriver
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kmMonth = double.Parse(Console.ReadLine());
            double kmPrice = 1.45;
            if (kmMonth <= 5000)
            {
                switch (season)
                {
                    case "spring":
                    case "autumn":
                        kmPrice = 0.75;
                        break;
                    case "summer":
                        kmPrice = 0.9;
                        break;
                    case "winter":
                        kmPrice = 1.05;
                        break;
                }
            }
            else if (kmMonth <= 10000)
            {
                switch (season)
                {
                    case "spring":
                    case "autumn":
                        kmPrice = 0.95;
                        break;
                    case "summer":
                        kmPrice = 1.1;
                        break;
                    case "winter":
                        kmPrice = 1.25;
                        break;
                }
            }
            Console.WriteLine($"{kmPrice * kmMonth * 4 * 0.9:f2}");
        }
    }
}