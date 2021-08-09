namespace WildFarm.Classes.Animals.Birds
{
    using System;
    using System.Collections.Generic;
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            WeightIncrease = 0.35;
            AcceptedFoods = new List<string> {"Fruit", "Meat", "Seeds", "Vegetable"};
        }

        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }
    }
}