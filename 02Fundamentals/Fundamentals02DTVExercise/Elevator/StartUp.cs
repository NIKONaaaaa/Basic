namespace Elevator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double people = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double trips = Math.Floor(people / capacity);
            if (people % capacity != 0)
            {
                trips++;
            }
            Console.WriteLine(trips);
        }
    }
}