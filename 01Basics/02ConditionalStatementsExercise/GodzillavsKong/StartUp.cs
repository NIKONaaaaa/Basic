namespace GodzillavsKong
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothp = double.Parse(Console.ReadLine());
            if (statists > 150)
            {
                if (budget * 0.1 + statists * clothp * 0.9 > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {budget * 0.1 + statists * clothp * 0.9 - budget:f2} leva more.");
                }
                else
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {budget * 0.9 - statists * clothp * 0.9:f2} leva left.");
                }
            }
            else
            {
                if (budget * 0.1 + statists * clothp > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {budget * 0.1 + statists * clothp - budget:f2} leva more.");
                }
                else
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {budget * 0.9 - statists * clothp:f2} leva left.");
                }
            }
        }
    }
}