namespace VehiclesExtension
{
    using System;
    public class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0.0d;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }
        public double LitersPerKm { get; set; }
        public double TankCapacity { get; set; }
        public double ACMod { get; set; }
        public double FuelMod { get; set; }

        public Vehicle(double fuel, double litersPerKM, double tankCapacity)
        {
            LitersPerKm = litersPerKM;
            TankCapacity = tankCapacity;
            FuelQuantity = fuel;
        }

        public void Drive(double distance)
        {
            if (FuelQuantity - (LitersPerKm + ACMod) * distance >= 0)
            {
                FuelQuantity -= (LitersPerKm + ACMod) * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else throw new Exception($"{GetType().Name} needs refueling");
        }

        public void Refuel(double liters)
        {
            if (liters <= 0.0)
            {
                throw new Exception("Fuel must be a positive number");
            }
            if (FuelQuantity + liters * FuelMod > TankCapacity)
            {
                throw new Exception($"Cannot fit {liters} fuel in the tank");
            }
            FuelQuantity += liters * FuelMod;
        }
    }
}