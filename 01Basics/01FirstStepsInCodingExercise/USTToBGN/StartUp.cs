namespace USDToBGN
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double rate = 1.79549;
            double bgn = usd * rate;
            Console.WriteLine($"{bgn:f2}");
        }
    }
}