namespace Vacation
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string vacationArea = "Morocco";
            string vacationLocation = "Hotel";
            double vacationPrice = 0.9;
            if (season == "summer")
            {
                vacationArea = "Alaska";
                if (budget <= 1000)
                {
                    vacationLocation = "Camp";
                    vacationPrice = 0.65;
                }
                else if (budget <= 3000)
                {
                    vacationLocation = "Hut";
                    vacationPrice = 0.8;
                }
            }
            else
            {
                if (budget <= 1000)
                {
                    vacationLocation = "Camp";
                    vacationPrice = 0.45;
                }
                else if (budget <= 3000)
                {
                    vacationLocation = "Hut";
                    vacationPrice = 0.6;
                }
            }
            Console.WriteLine($"{vacationArea} - {vacationLocation} - {(budget * vacationPrice):f2}");
        }
    }
}