namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int carNumber = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carNumber; i++)
            {
                string input = Console.ReadLine();
                Car car = new Car(input.Split(" ")[0], double.Parse(input.Split()[1]), double.Parse(input.Split()[2]));
                cars.Add(car);
            }
            string[] command = Console.ReadLine().Split(" ");
            while (command[0] != "End")
            {
                Car.MoveCar(cars.FirstOrDefault(car => car.Model == command[1]), int.Parse(command[2]));
                command = Console.ReadLine().Split(" ");
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
        class Car
        {
            public string Model { get; }
            public double FuelAmount { get; private set; }
            private double FuelConsumption { get; }
            public int DistanceTraveled { get; private set; }
            public Car(string model, double fuelTotal, double fuelConsumption)
            {
                Model = model;
                FuelAmount = fuelTotal;
                FuelConsumption = fuelConsumption;
            }
            public static void MoveCar(Car model, int distance)
            {
                if (model.FuelAmount >= distance * model.FuelConsumption)
                {
                    model.FuelAmount -= model.FuelConsumption * distance;
                    model.DistanceTraveled += distance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }
    }
}