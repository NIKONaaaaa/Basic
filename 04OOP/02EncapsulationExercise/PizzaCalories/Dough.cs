namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    public class Dough
    {
        private const double CaloriesPerGram = 2.0;
        private readonly Dictionary<string, double> flourTypes = new Dictionary<string, double>
        {
            { "white", 1.5},
            { "wholegrain", 1.0},
        };
        private readonly Dictionary<string, double> bakingTechniques = new Dictionary<string, double>
        {
            { "crispy", 0.9},
            { "chewy", 1.1},
            { "homemade", 1.0},
        };

        private string flourType;
        private string bakingTechnique;
        private int weightInGrams;

        public string FlourType
        {
            get => flourType;
            private set
            {
                if (!flourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value.ToLower();
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (!bakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value.ToLower();
            }
        }

        public int WeightInGrams
        {
            get => weightInGrams;
            private set
            {
                if (1 > value || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weightInGrams = value;
            }
        }

        public Dough(string flour, string bakingTechnique, int weight)
        {
            FlourType = flour;
            BakingTechnique = bakingTechnique;
            WeightInGrams = weight;
        }

        internal double GetCalories()
        {
            return CaloriesPerGram * WeightInGrams * flourTypes[FlourType] * bakingTechniques[BakingTechnique];
        }
    }
}