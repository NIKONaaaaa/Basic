namespace WildFarm
{
    using System;
    using Classes.Animals;
    using Classes.Animals.Birds;
    using Classes.Animals.Mammals;
    using Classes.Animals.Mammals.Felines;
    public class AnimalCreator
    {
        public static Animal CreateAnimal(string input)
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "Hen":
                    Animal newHen = new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                    return newHen;
                case "Owl":
                    Animal newOwl = new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                    return newOwl;
                case "Cat":
                    Animal newCat = new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                    return newCat;
                case "Tiger":
                    Animal newTiger = new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                    return newTiger;
                case "Dog":
                    Animal newDog = new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
                    return newDog;
                case "Mouse":
                    Animal newMouse = new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
                    return newMouse;
                default:
                    return null;
            }
        }
    }
}