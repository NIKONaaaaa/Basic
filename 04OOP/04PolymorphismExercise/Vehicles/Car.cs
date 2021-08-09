namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuel, double litersPerKM) : base(fuel, litersPerKM)
        {
            ACMod = 0.9d;
            FuelMod = 1.0d;
        }
    }
}