namespace PizzaCalories
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            try
            {
                Pizza pizza = new Pizza("Pizza", new Dough("White", "Chewy", 1));

                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] tokens = input.Split();
                    if (tokens[0] == "Pizza")
                    {
                        pizza.Name = tokens[1];
                    }
                    else if (tokens[0] == "Dough")
                    {
                        pizza.Dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
                    }
                    else if (tokens[0] == "Topping")
                    {
                        pizza.AddTopping(new Topping(tokens[1], int.Parse(tokens[2])));
                    }

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}