namespace ToyShop
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzleNumber = int.Parse(Console.ReadLine());
            int dollNumber = int.Parse(Console.ReadLine());
            int teddyNumber = int.Parse(Console.ReadLine());
            int minionNumber = int.Parse(Console.ReadLine());
            int truckNumber = int.Parse(Console.ReadLine());
            double puzzlePrice = 2.6;
            double dollPrice = 3;
            double teddyPrice = 4.1;
            double minionPrice = 8.2;
            double truckPrice = 2;
            int toyNumber = puzzleNumber + dollNumber + teddyNumber + minionNumber + truckNumber;
            double revenue = (puzzleNumber * puzzlePrice + dollNumber * dollPrice + teddyNumber * teddyPrice + minionNumber * minionPrice + truckNumber * truckPrice);
            double discount = 1;
            if (toyNumber >= 50)
            {
                discount -= 0.25;
            }
            double profit = revenue * discount * 0.9;
            if (profit >= excursionPrice)
            {
                Console.WriteLine($"Yes! {profit - excursionPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice - profit:f2} lv needed.");
            }
        }
    }
}