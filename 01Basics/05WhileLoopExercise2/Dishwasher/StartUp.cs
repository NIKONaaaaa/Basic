namespace Dishwasher
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int liquidAmount = int.Parse(Console.ReadLine()) * 750;
            int dishCount = 0;
            int potCount = 0;
            int i = 1;
            string input = (Console.ReadLine());
            while (0 <= liquidAmount && input != "End")
            {
                liquidAmount -= int.Parse(input) * 5;
                dishCount += int.Parse(input);
                input = (Console.ReadLine());
                i++;
                if (i % 3 == 0 && input != "End")
                {
                    liquidAmount -= int.Parse(input) * 15;
                    potCount += int.Parse(input);
                    input = (Console.ReadLine());
                    i++;
                }
            }
            if (0 <= liquidAmount)
            {
                Console.WriteLine("Detergent was enough!" + "\n" + $"{dishCount} dishes and {potCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {liquidAmount} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(liquidAmount)} ml. more necessary!");
            }
        }
    }
}