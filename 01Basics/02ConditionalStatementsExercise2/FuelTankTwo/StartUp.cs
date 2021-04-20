namespace FuelTankTwo
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.Title = "Fuel Cost Calculator";
        checkOne:
            Console.Clear();
            Console.WriteLine("Enter fuel type (Gas / Gasoline / Diesel):");
            string fuelType = Console.ReadLine();
            if (fuelType != "Gas" && fuelType != "Gasoline" && fuelType != "Diesel")
            {
                Console.Clear();
                Console.WriteLine("Invalid fuel.");
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                goto checkOne;
            }
        checkTwo:
            Console.Clear();
            Console.WriteLine($"Fuel type chosen is {fuelType}.");
            Console.WriteLine("Enter fuel amount:");
            double fuelAmount = double.Parse(Console.ReadLine());
            if (fuelAmount < 0)
            {
                Console.Clear();
                Console.WriteLine("Invalid amount.");
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                goto checkTwo;
            }
        checkThree:
            Console.Clear();
            Console.WriteLine($"Fuel type chosen is {fuelType}.");
            Console.WriteLine($"Fuel amount is {fuelAmount:f2} litres.");
            Console.WriteLine("Do you have a club card? Y / N");
            string card = Console.ReadLine();
            if (card != "Y" && card != "y" && card != "N" && card != "n")
            {
                Console.Clear();
                Console.WriteLine("Invalid input.");
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                goto checkThree;
            }
            double gasPrice = 0.93;
            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;
            double gasDiscount = 0.08;
            double gasolineDiscount = 0.18;
            double dieselDiscount = 0.12;
            double volumeDiscount = 1;
            double totalFuelPrice = 0;
            if (card == "Y" || card == "y")
            {
                gasPrice -= gasDiscount;
                gasolinePrice -= gasolineDiscount;
                dieselPrice -= dieselDiscount;
            }
            if (fuelAmount > 25)
            {
                volumeDiscount = 0.9;
            }
            else if (fuelAmount >= 20)
            {
                volumeDiscount = 0.92;
            }
            Console.Clear();
            switch (fuelType)
            {
                case "Gas":
                    totalFuelPrice = fuelAmount * gasPrice * volumeDiscount;
                    break;
                case "Gasoline":
                    totalFuelPrice = fuelAmount * gasolinePrice * volumeDiscount;
                    break;
                case "Diesel":
                    totalFuelPrice = fuelAmount * dieselPrice * volumeDiscount;
                    break;
            }
            Console.WriteLine($"The total price for {fuelAmount:f2} litres of {fuelType} is {totalFuelPrice:f2} lv.");
        }
    }
}