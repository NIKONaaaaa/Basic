namespace WildFarm.Classes.Animals.Mammals
{
    using System;
    using System.Collections.Generic;
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            WeightIncrease = 0.4;
            AcceptedFoods = new List<string> { "Meat" };
        }

        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }
    }
}