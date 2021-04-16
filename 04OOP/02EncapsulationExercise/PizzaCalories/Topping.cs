namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    public class Topping
    {
        private const double CaloriesPerGram = 2.0;
        private readonly Dictionary<string, double> toppingTypes = new Dictionary<string, double>
        {
            { "veggies", 0.8},
            { "sauce", 0.9},
            { "cheese", 1.1},
            { "meat", 1.2}
        };

        private string type;
        private int weightInGrams;

        public Topping(string type, int weight)
        {
            Type = type;
            WeightInGrams = weight;
        }

        public string Type
        {
            get => type;
            private set
            {
                if (!toppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value.ToLower();
            }
        }

        public int WeightInGrams
        {
            get => weightInGrams;
            private set
            {
                if (1 > value || value > 50)
                {
                    throw new ArgumentException($"{Type[0].ToString().ToUpper() + Type[1..]} weight should be in the range [1..50].");
                }
                weightInGrams = value;
            }
        }

        internal double GetCalories()
        {
            return CaloriesPerGram * WeightInGrams * toppingTypes[Type];
        }
    }
}