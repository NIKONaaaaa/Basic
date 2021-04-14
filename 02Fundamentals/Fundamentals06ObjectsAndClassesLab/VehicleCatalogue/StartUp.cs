namespace VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<Vehicle> cataloguedVehicles = new List<Vehicle>();
            PopulateCatalogue(cataloguedVehicles);
            PrintAllVehicles(cataloguedVehicles);
        }
        private static void PopulateCatalogue(List<Vehicle> cataloguedVehicles)
        {
            string[] commandInput = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries);
            while (commandInput[0] != "end")
            {
                if (commandInput[0] == "Car")
                {
                    cataloguedVehicles.Add(new Vehicle(new Car(commandInput[1], commandInput[2], int.Parse(commandInput[3]))));
                }
                else
                {
                    cataloguedVehicles.Add(new Vehicle(new Truck(commandInput[1], commandInput[2], int.Parse(commandInput[3]))));
                }
                commandInput = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries);
            }
        }
        private static void PrintAllVehicles(List<Vehicle> cataloguedVehicles)
        {
            Console.WriteLine("Cars:");
            foreach (Vehicle entry in cataloguedVehicles.Where(vehicle => vehicle.Cars != null).OrderBy(brand => brand.Cars.Brand))
            {
                Console.WriteLine($"{entry.Cars.Brand}: {entry.Cars.Model} - {entry.Cars.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Vehicle entry in cataloguedVehicles.Where(vehicle => vehicle.Trucks != null).OrderBy(brand => brand.Trucks.Brand))
            {
                Console.WriteLine($"{entry.Trucks.Brand}: {entry.Trucks.Model} - {entry.Trucks.Weight}kg");
            }
        }
    }
}
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
    public Car(string brand, string model, int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }
}
class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
    public Truck(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
}
class Vehicle
{
    public Car Cars { get; set; }
    public Truck Trucks { get; set; }
    public Vehicle(Truck truck)
    {
        Trucks = truck;
    }
    public Vehicle(Car car)
    {
        Cars = car;
    }
}