namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double litersPerKM) : base(fuel, litersPerKM)
        {
            ACMod = 1.6d;
            FuelMod = 0.95d;
        }
    }
}