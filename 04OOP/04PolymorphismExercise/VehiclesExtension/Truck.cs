namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double litersPerKM, double tankCapacity) : base(fuel, litersPerKM, tankCapacity)
        {
            ACMod = 1.6d;
            FuelMod = 0.95d;
        }
    }
}