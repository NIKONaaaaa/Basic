namespace SuperMarket
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            Queue<string> shoppers = new Queue<string>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (0 < shoppers.Count)
                    {
                        Console.WriteLine(shoppers.Dequeue());
                    }
                }
                else
                {
                    shoppers.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{shoppers.Count} people remaining.");
        }
    }
}