namespace TrafficJam
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            int carsToPass = int.Parse(Console.ReadLine()), carsPassed = 0;
            Queue<string> cars = new Queue<string>();
            string car = Console.ReadLine();
            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        carsPassed++;
                    }
                }
                else
                {
                    cars.Enqueue(car);
                }
                car = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}