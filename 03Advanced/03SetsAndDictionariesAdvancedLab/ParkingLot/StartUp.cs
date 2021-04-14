namespace ParkingLot
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();
            while (input != "END")
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
                input = Console.ReadLine();
            }
            Console.WriteLine(cars.Count == 0 ? "Parking Lot is Empty" : string.Join(Environment.NewLine, cars));
        }
    }
}