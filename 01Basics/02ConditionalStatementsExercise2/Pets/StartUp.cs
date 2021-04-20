namespace Pets
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int totalFoodKG = int.Parse(Console.ReadLine());
            double dogFoodKG = double.Parse(Console.ReadLine());
            double catFoodKG = double.Parse(Console.ReadLine());
            double turtleFoodGR = double.Parse(Console.ReadLine());
            double foodEaten = ((dogFoodKG + catFoodKG + turtleFoodGR / 1000) * days);
            if (totalFoodKG - foodEaten >= 0)
            {
                Console.WriteLine($"{Math.Floor(totalFoodKG - foodEaten)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodEaten - totalFoodKG)} more kilos of food are needed.");
            }
        }
    }
}