namespace MatchTickets
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleNumber = int.Parse(Console.ReadLine());
            double ticketPrice = 249.99;
            double transportCost = 0.75;
            if (category == "VIP")
            {
                ticketPrice = 499.99;
            }
            if (5 <= peopleNumber && peopleNumber <= 24)
            {
                transportCost = 0.6;
                if (10 <= peopleNumber)
                {
                    transportCost = 0.5;
                }
            }
            else if (25 <= peopleNumber)
            {
                transportCost = 0.4;
                if (50 <= peopleNumber)
                {
                    transportCost = 0.25;
                }
            }
            double totalCost = budget * transportCost + ticketPrice * peopleNumber;
            if (totalCost > budget)
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budget - totalCost:f2} leva left.");
            }
        }
    }
}