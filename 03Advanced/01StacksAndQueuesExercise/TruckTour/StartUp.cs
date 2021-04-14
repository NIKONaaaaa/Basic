namespace TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int numberOfPumps = int.Parse(Console.ReadLine()), startIndex = 0, visitedPumps = 0;
            Queue<Pump> pumps = new Queue<Pump>();
            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                pumps.Enqueue(new Pump(input[0], input[1]));
            }
            while (visitedPumps != numberOfPumps)
            {
                Queue<Pump> journey = new Queue<Pump>(pumps);
                for (int i = 0; i < startIndex; i++)
                {
                    journey.Enqueue(journey.Dequeue());
                }
                int petrol = 0;
                visitedPumps = 0;
                while (0 < journey.Count)
                {
                    petrol += journey.Peek().Petrol;
                    if (petrol < journey.Peek().Distance)
                    {
                        startIndex++;
                        break;
                    }
                    petrol -= journey.Dequeue().Distance;
                    visitedPumps++;
                }
            }
            Console.WriteLine(startIndex);
        }
        public class Pump
        {
            public int Petrol { get; set; }
            public int Distance { get; set; }
            public Pump(int petrol, int distance)
            {
                Petrol = petrol;
                Distance = distance;
            }
        }
    }
}