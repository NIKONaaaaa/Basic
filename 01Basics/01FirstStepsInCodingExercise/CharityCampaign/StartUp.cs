namespace CharityCampaign
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double cakePrice = 45;
            double gofPrice = 5.8;
            double pancakePrice = 3.2;
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakeNumber = int.Parse(Console.ReadLine());
            int gofNumber = int.Parse(Console.ReadLine());
            int pancakeNumber = int.Parse(Console.ReadLine());
            double bakerOut = cakeNumber * cakePrice + gofNumber * gofPrice + pancakeNumber * pancakePrice;
            double totalOut = bakerOut * days * bakers;
            double totalExpenses = totalOut / 8;
            double sum = totalOut - totalExpenses;
            Console.WriteLine($"{sum:f2}");
        }
    }
}