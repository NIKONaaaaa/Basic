namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Queue<Animal> animals = new Queue<Animal>();
            string input = Console.ReadLine();
            while (input != "Beast!")
            {
                string[] animal = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = animal[0];
                int age = int.Parse(animal[1]);
                string gender = animal[2];
                if ((gender != "Male" && gender != "Female") || age < 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    switch (input)
                    {
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age);
                            animals.Enqueue(tomcat);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name, age);
                            animals.Enqueue(kitten);
                            break;
                        case "Cat":
                            Cat cat = new Cat(name, age, gender);
                            animals.Enqueue(cat);
                            break;
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            animals.Enqueue(dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            animals.Enqueue(frog);
                            break;
                    }

                    input = Console.ReadLine();
                }

                while (animals.Count > 0)
                {
                    Console.WriteLine(animals.Dequeue().ToString());
                }
            }
        }
    }
}