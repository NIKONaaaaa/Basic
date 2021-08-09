namespace WildFarm.Classes.Animals
{
    using System.Collections.Generic;
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }
        public double WeightIncrease { get; set; }
        public List<string> AcceptedFoods { get; set; }

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public abstract void AskForFood();
    }
}