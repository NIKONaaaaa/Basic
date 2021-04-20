namespace Harvest
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerSQM = double.Parse(Console.ReadLine());
            int wine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double grapesTotal = area * grapesPerSQM * 0.4;
            double wineTotal = grapesTotal / 2.5;
            if (wineTotal < wine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wine - wineTotal)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineTotal)} liters.");
                double litersLeft = Math.Ceiling(wineTotal - wine);
                double winePerPerson = Math.Ceiling(litersLeft / workers);
                Console.WriteLine($"{litersLeft} liters left -> {winePerPerson} liters per person.");
            }
        }
    }
}