namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }
        public double LitersPerKm { get; set; }
        public double ACMod { get; set; }
        public double FuelMod { get; set; }
        public void Drive(double distance);
        public void Refuel(double liters);
    }
}