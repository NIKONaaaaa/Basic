namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using Classes.Animals;
    using Classes.Foods;
    public class StartUp
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                Animal newAnimal = AnimalCreator.CreateAnimal(command);

                try
                {
                    Food newFood = FoodCreator.CreateFood(Console.ReadLine());
                    newAnimal.AskForFood();
                    if (newAnimal.AcceptedFoods.Contains(newFood.GetType().Name))
                    {
                        newAnimal.FoodEaten += newFood.Quantity;
                        newAnimal.Weight += newAnimal.WeightIncrease * newFood.Quantity;
                    }
                    else
                    {
                        throw new ArgumentException($"{newAnimal.GetType().Name} does not eat {newFood.GetType().Name}!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(newAnimal);
                command = Console.ReadLine();
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}