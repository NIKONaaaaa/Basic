namespace ConvertMetersToKilometers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            decimal metres = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{metres / 1000:f2}");
        }
    }
}