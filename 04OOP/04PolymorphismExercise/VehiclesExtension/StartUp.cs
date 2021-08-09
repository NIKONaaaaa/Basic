namespace VehiclesExtension
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car carEntity = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Truck truckEntity = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Bus busEntity = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            int commandNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandNumber; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (input[0] == "Drive")
                    {
                        if (input[1] == "Car")
                        {
                            carEntity.Drive(double.Parse(input[2]));
                        }
                        else if (input[1] == "Truck")
                        {
                            truckEntity.Drive(double.Parse(input[2]));
                        }
                        else if (input[1] == "Bus")
                        {
                            busEntity.ACMod = 1.4d;
                            busEntity.Drive(double.Parse(input[2]));
                        }
                    }
                    else if (input[0] == "Refuel")
                    {
                        if (input[1] == "Car")
                        {
                            carEntity.Refuel(double.Parse(input[2]));
                        }
                        else if (input[1] == "Truck")
                        {
                            truckEntity.Refuel(double.Parse(input[2]));
                        }
                        else if (input[1] == "Bus")
                        {
                            truckEntity.Refuel(double.Parse(input[2]));
                        }
                    }
                    else if (input[0] == "DriveEmpty")
                    {
                        busEntity.ACMod = 0.0d;
                        busEntity.Drive(double.Parse(input[2]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {carEntity.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truckEntity.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {busEntity.FuelQuantity:f2}");
        }
    }
}