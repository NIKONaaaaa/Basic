namespace OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            PopulateAndPrintList(people);
        }
        private static void PopulateAndPrintList(List<Person> people)
        {
            string[] commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (commandInput[0] != "End")
            {
                Person person = new Person(commandInput[0], commandInput[1], int.Parse(commandInput[2]));
                people.Add(person);
                commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (Person entry in people.OrderBy(entry => entry.Age))
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string PersonalNumber { get; set; }
        public int Age { get; set; }
        public Person(string name, string id, int age)
        {
            Name = name;
            PersonalNumber = id;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} with ID: {PersonalNumber} is {Age} years old.";
        }
    }
}