namespace WildFarm
{
    using System;
    using Classes.Foods;
    public class FoodCreator
    {
        public static Food CreateFood(string input)
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "Vegetable":
                    Food newVegetable = new Vegetable(int.Parse(tokens[1]));
                    return newVegetable;
                case "Fruit":
                    Food newFruit = new Fruit(int.Parse(tokens[1]));
                    return newFruit;
                case "Meat":
                    Food newMeat = new Meat(int.Parse(tokens[1]));
                    return newMeat;
                case "Seeds":
                    Food newSeeds = new Seeds(int.Parse(tokens[1]));
                    return newSeeds;
                default:
                    return null;
            }
        }
    }
}