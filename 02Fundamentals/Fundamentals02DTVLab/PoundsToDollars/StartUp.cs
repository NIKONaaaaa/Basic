namespace PoundsToDollars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double pounds = double.Parse(Console.ReadLine());
            decimal dollars = (decimal)(pounds * 1.31);
            Console.WriteLine($"{dollars:f3}");
        }
    }
}