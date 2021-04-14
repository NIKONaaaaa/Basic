namespace FruitMarket
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double berryKg = double.Parse(Console.ReadLine());
            double strawberryKg = double.Parse(Console.ReadLine());
            double berryPrice = strawberryPrice * 0.5;
            double bananaPrice = berryPrice * 0.2;
            double orangePrice = berryPrice * 0.6;
            double strawberryTotal = strawberryPrice * strawberryKg;
            double bananaTotal = bananaKg * bananaPrice;
            double orangeTotal = orangeKg * orangePrice;
            double berryTotal = berryKg * berryPrice;
            double sum = strawberryTotal + bananaTotal + orangeTotal + berryTotal;
            Console.WriteLine($"{sum:f2}");
        }
    }
}