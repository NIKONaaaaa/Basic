namespace ParkingLot
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            HashSet<string> cars = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string direction = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)[0];
                string car = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)[1];
                if (direction == "IN")
                {
                    cars.Add(car);
                }
                else
                {
                    cars.Remove(car);
                }
            }
            Console.WriteLine(cars.Count == 0 ? "Parking Lot is Empty" : string.Join(Environment.NewLine, cars));
        }
    }
}