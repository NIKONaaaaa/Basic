namespace VehiclesExtension
{
    using System;
    public class Bus : Vehicle
    {
        public Bus(double fuel, double litersPerKM, double tankCapacity) : base(fuel, litersPerKM, tankCapacity)
        {
            ACMod = 0.0d;
            FuelMod = 1.0d;
        }
    }
}