namespace VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<Catalogue> catalogues = new List<Catalogue>();
            string[] commandInput = Console.ReadLine().Split(" ");
            while (commandInput[0] != "End")
            {
                Catalogue catalogue = new Catalogue();
                if (commandInput[0] == "car")
                {
                    Car car = new Car(commandInput[1], commandInput[2], int.Parse(commandInput[3]));
                    catalogue = new Catalogue(car);
                }
                else if (commandInput[0] == "truck")
                {
                    Truck truck = new Truck(commandInput[1], commandInput[2], int.Parse(commandInput[3]));
                    catalogue = new Catalogue(truck);
                }
                catalogues.Add(catalogue);
                commandInput = Console.ReadLine().Split(" ");
            }
            string vehicleModel = Console.ReadLine();
            while (vehicleModel != "Close the Catalogue")
            {
                foreach (Catalogue entry in catalogues.Where(vehicle => (vehicle.Car != null && vehicle.Car.Model == vehicleModel) || (vehicle.Truck != null && vehicle.Truck.Model == vehicleModel)))
                {
                    if (entry.Car != null)
                    {
                        entry.Car.PrintInfo();
                    }
                    else
                    {
                        entry.Truck.PrintInfo();
                    }
                }
                vehicleModel = Console.ReadLine();
            }
            PrintAverageHorsePower("Cars", catalogues);
            PrintAverageHorsePower("Trucks", catalogues);
        }
        private static void PrintAverageHorsePower(string typeOfVehicle, List<Catalogue> catalogues)
        {
            double horsePower = 0;
            int vehicleCount = 0;
            if (typeOfVehicle == "Cars")
            {
                foreach (Catalogue entry in catalogues.Where(x => x.Car != null))
                {
                    vehicleCount++;
                    horsePower += entry.Car.HorsePower;
                }
                if (vehicleCount == 0)
                {
                    vehicleCount = 1;
                }
                Console.WriteLine($"{typeOfVehicle} have average horsepower of: {horsePower / vehicleCount:F2}.");
            }
            else
            {
                foreach (Catalogue entry in catalogues.Where(x => x.Truck != null))
                {
                    vehicleCount++;
                    horsePower += entry.Truck.HorsePower;
                }
                if (vehicleCount == 0)
                {
                    vehicleCount = 1;
                }
                Console.WriteLine($"{typeOfVehicle} have average horsepower of: {horsePower / vehicleCount:F2}.");
            }
        }
    }
    class Truck
    {
        public string Model { get; set; }
        public string Colour { get; set; }
        public int HorsePower { get; set; }
        public Truck(string model, string colour, int horsePower)
        {
            Model = model;
            Colour = colour;
            HorsePower = horsePower;
        }
        public Truck()
        {
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Type: Truck");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Colour}");
            Console.WriteLine($"Horsepower: {HorsePower}");
        }
    }
    class Car
    {
        public string Model { get; set; }
        public string Colour { get; set; }
        public int HorsePower { get; set; }
        public Car(string model, string colour, int horsePower)
        {
            Model = model;
            Colour = colour;
            HorsePower = horsePower;
        }
        public Car()
        {
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Type: Car");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Colour}");
            Console.WriteLine($"Horsepower: {HorsePower}");
        }
    }
    class Catalogue
    {
        public Truck Truck { get; set; }
        public Car Car { get; set; }
        public Catalogue(Truck truck)
        {
            Truck = truck;
        }
        public Catalogue(Car car)
        {
            Car = car;
        }
        public Catalogue()
        {
        }
    }
}