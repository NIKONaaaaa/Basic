namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int vehicleNumber = int.Parse(Console.ReadLine());
            List<Vehicle> vehicles = new List<Vehicle>();
            for (int i = 0; i < vehicleNumber; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                Vehicle vehicle = new Vehicle(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4]);
                vehicles.Add(vehicle);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (Vehicle vehicle in vehicles.Where(vehicle => vehicle.CargoSpecs.Type == "fragile" && vehicle.CargoSpecs.Weight < 1000))
                {
                    Console.WriteLine(vehicle.Model);
                }
            }
            else
            {
                foreach (Vehicle vehicle in vehicles.Where(vehicle => vehicle.CargoSpecs.Type == "flamable" && 250 < vehicle.EngineSpecs.Power))
                {
                    Console.WriteLine(vehicle.Model);
                }
            }
        }
    }
    class Vehicle
    {
        internal string Model { get; set; }
        public Engine EngineSpecs { get; }
        public Cargo CargoSpecs { get; }
        public Vehicle(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Model = model;
            EngineSpecs = new Engine(engineSpeed, enginePower);
            CargoSpecs = new Cargo(cargoWeight, cargoType);
        }
    }
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}