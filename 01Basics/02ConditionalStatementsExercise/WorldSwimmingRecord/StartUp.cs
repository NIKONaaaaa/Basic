namespace WorldSwimmingRecord
{
    using System;
    using System.Reflection;

    class StartUp
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double dist = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            double delay = Math.Floor(dist / 15) * 12.5;
            double totalTime = dist * speed + delay;
            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:f2} seconds slower.");
            }
        }
    }
}