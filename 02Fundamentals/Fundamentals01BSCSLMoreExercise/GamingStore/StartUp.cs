namespace GamingStore
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string[] titles = { "OutFall 4", "CS: OG", "Zplinter Zell", "Honored 2", "RoverWatch", "RoverWatch Origins Edition" };
            double[] prices = { 39.99, 15.99, 19.99, 59.99, 29.99, 39.99 };
            double total = 0;
            bool check = true;
            while (true)
            {
                string input = Console.ReadLine();
                int index = Array.IndexOf(titles, input);
                if (input == "Game Time")
                {
                    break;
                }
                if (index < 0)
                {
                    Console.WriteLine("Not Found");
                }
                else if (budget < prices[index])
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    budget -= prices[index];
                    Console.WriteLine($"Bought {titles[index]}");
                    total += prices[index];
                }
                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${budget:f2}");
            }
        }
    }
}