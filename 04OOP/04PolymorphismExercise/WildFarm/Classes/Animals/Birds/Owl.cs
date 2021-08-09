namespace WildFarm.Classes.Animals.Birds
{
    using System;
    using System.Collections.Generic;
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            WeightIncrease = 0.25;
            AcceptedFoods = new List<string> { "Meat" };
        }

        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}