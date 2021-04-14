namespace CarRace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<double> bothRacers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            List<double> leftRacer = bothRacers.GetRange(0, bothRacers.Count / 2).ToList(), rightRacer = bothRacers.GetRange(bothRacers.Count - bothRacers.Count / 2, bothRacers.Count / 2).ToList();
            rightRacer.Reverse();
            double sumLeft = GetTime(leftRacer), sumRight = GetTime(rightRacer);
            if (sumLeft < sumRight)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumRight}");
            }
        }
        static double GetTime(List<double> times)
        {
            double sum = 0;
            foreach (double time in times)
            {
                if (time == 0)
                {
                    sum -= sum * 0.2;
                }
                sum += time;
            }
            return sum;
        }
    }
}