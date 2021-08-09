namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fuel, double litersPerKM, double tankCapacity) : base(fuel, litersPerKM, tankCapacity)
        {
            ACMod = 0.9d;
            FuelMod = 1.0d;
        }
    }
}