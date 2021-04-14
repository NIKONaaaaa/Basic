namespace SoftUniParking
{
    using System.Collections.Generic;
    using System.Linq;
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new List<Car>();
        }
        public int Count => cars.Count();
        public string AddCar(Car car)
        {
            if (cars.Any(newCar => newCar.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }
        public string RemoveCar(string registrationNumber)
        {
            if (cars.All(car => car.RegistrationNumber != registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(cars.FirstOrDefault(car => car.RegistrationNumber == registrationNumber));
            return $"Successfully removed {registrationNumber}";
        }
        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(car => car.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string currentNumber in registrationNumbers)
            {
                cars.RemoveAll(car => car.RegistrationNumber == currentNumber);
            }
        }
    }
}