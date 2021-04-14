namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<Tire[]> tireList = new List<Tire[]>();
            while (input != "No more tires")
            {
                Tire[] tires = new Tire[input.Split().Length / 2];
                for (int i = 0; i < input.Split().ToArray().Length; i += 2)
                {
                    string[] split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    tires[i / 2] = new Tire(int.Parse(split[i]), double.Parse(split[i + 1]));
                }
                tireList.Add(tires);
                input = Console.ReadLine();
            }
            List<Engine> engineList = new List<Engine>();
            input = Console.ReadLine();
            while (input != "Engines done")
            {
                string[] split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                engineList.Add(new Engine(int.Parse(split[0]), double.Parse(split[1])));
                input = Console.ReadLine();
            }
            List<Car> cars = new List<Car>();
            input = Console.ReadLine();
            while (input != "Show special")
            {
                string[] split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                cars.Add(new Car(split[0], split[1], int.Parse(split[2]), double.Parse(split[3]), double.Parse(split[4]), engineList[int.Parse(split[5])], tireList[int.Parse(split[6])]));
                input = Console.ReadLine();
            }
            Func<int, int, double, bool> special = (year, horsePower, pressure) => year >= 2017 && horsePower > 330 && 9 <= pressure && pressure <= 10;
            List<Car> specialCars = cars.Where(car => special(car.Year, car.Engine.HorsePower, car.Tires.Sum(tire => tire.Pressure))).ToList();
            foreach (Car car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}