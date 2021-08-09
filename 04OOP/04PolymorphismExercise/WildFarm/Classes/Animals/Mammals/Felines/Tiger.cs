namespace WildFarm.Classes.Animals.Mammals.Felines
{
    using System;
    using System.Collections.Generic;
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            WeightIncrease = 1.0;
            AcceptedFoods = new List<string> { "Meat" };
        }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}