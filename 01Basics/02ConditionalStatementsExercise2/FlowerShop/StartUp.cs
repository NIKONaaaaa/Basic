namespace FlowerShop
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double magnoliaPrice = 3.25;
            double hyacinthPrice = 4;
            double rosePrice = 3.5;
            double cactusPrice = 8;
            int magnoliaAmount = int.Parse(Console.ReadLine());
            int hyacinthAmount = int.Parse(Console.ReadLine());
            int roseAmount = int.Parse(Console.ReadLine());
            int cactusAmount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            double profit = (magnoliaPrice * magnoliaAmount + hyacinthPrice * hyacinthAmount + rosePrice * roseAmount + cactusPrice * cactusAmount) * 0.95;
            if (profit >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - profit)} leva.");
            }
        }
    }
}