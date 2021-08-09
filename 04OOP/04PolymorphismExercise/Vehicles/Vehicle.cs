namespace Vehicles
{
    using System;
    public class Vehicle : IVehicle
    {
        public double FuelQuantity { get; set; }
        public double LitersPerKm { get; set; }
        public double ACMod { get; set; }
        public double FuelMod { get; set; }

        public Vehicle(double fuel, double litersPerKM)
        {
            FuelQuantity = fuel;
            LitersPerKm = litersPerKM;
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
            FuelQuantity += liters * FuelMod;
        }
    }
}