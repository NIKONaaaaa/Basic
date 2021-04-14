namespace FishTank
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = length * width * height;
            double liters = volume / 1000;
            double water = liters * (1 - percent / 100);
            Console.WriteLine($"{water}");
        }
    }
}