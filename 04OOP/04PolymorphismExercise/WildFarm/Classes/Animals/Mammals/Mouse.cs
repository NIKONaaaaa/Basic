namespace WildFarm.Classes.Animals.Mammals
{
    using System;
    using System.Collections.Generic;
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            WeightIncrease = 0.1;
            AcceptedFoods = new List<string> { "Fruit", "Vegetable" };
        }

        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }
    }
}