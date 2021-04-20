namespace CarToGo
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string carType = "Jeep";
            string carClass = "Luxury class";
            double carPrice = 0.9;
            if (budget <= 100)
            {
                carClass = "Economy class";
                carPrice = 0.65;
                if (season == "summer")
                {
                    carType = "Cabrio";
                    carPrice = 0.35;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                carPrice = 0.8;
                if (season == "summer")
                {
                    carType = "Cabrio";
                    carPrice = 0.45;
                }
            }
            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {(budget * carPrice):f2}");
        }
    }
}