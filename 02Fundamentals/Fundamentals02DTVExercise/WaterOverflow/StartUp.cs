namespace WaterOverflow
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine()), tankVolume = 255;
            for (int i = 1; i <= number; i++)
            {
                int fill = int.Parse(Console.ReadLine());
                if (tankVolume < fill)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankVolume -= fill;
                }
            }
            Console.WriteLine(255 - tankVolume);
        }
    }
}