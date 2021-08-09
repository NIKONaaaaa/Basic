namespace WildFarm.Classes.Animals.Mammals.Felines
{
    using System;
    using System.Collections.Generic;
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            WeightIncrease = 0.3;
            AcceptedFoods = new List<string> { "Meat", "Vegetable" };
        }

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }
    }
}