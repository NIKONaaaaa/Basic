namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Puppy puppy = new Puppy();
            Cat cat = new Cat();
            animal.Eat();
            dog.Eat();
            dog.Bark();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            cat.Eat();
            cat.Meow();
        }
    }
}