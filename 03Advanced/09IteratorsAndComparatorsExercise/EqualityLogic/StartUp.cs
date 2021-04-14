namespace EqualityLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            HashSet<Person> hashedPeople = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            int commandNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandNumber; i++)
            {
                string[] person = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = person[0];
                int age = int.Parse(person[1]);
                Person newPerson = new Person(name, age);
                hashedPeople.Add(newPerson);
                sortedPeople.Add(newPerson);
            }
            Console.WriteLine(hashedPeople.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}