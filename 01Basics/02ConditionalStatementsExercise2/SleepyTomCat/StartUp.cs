namespace SleepyTomCat
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int workDays = 365 - daysOff;
            const double minuteLimit = 30000;
            double playTime = daysOff * 127 + workDays * 63;
            if (playTime > minuteLimit)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor((playTime - minuteLimit) / 60)} hours and {(playTime - minuteLimit) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor((minuteLimit - playTime) / 60)} hours and {(minuteLimit - playTime) % 60} minutes less for play");
            }
        }
    }
}