namespace AnimalType
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string animalName = Console.ReadLine().ToLower();
            string animalType = "";
            switch (animalName)
            {
                case "dog":
                    animalType = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    animalType = "reptile";
                    break;
                default:
                    animalType = "unknown";
                    break;
            }
            Console.WriteLine($"{animalType}");
        }
    }
}