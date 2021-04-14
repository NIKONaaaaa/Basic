namespace OldestFamilyMember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int familyMembers = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 1; i <= familyMembers; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                family.AddMember(new Person(input[0], int.Parse(input[1])));
            }
            Console.WriteLine(family.GetOldestMember().ToString());
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
    public class Family
    {
        public List<Person> FamilyRoster { get; set; }
        public Family()
        {
            FamilyRoster = new List<Person>();
        }
        internal void AddMember(Person person)
        {
            FamilyRoster.Add(person);
        }
        public Person GetOldestMember()
        {
            return FamilyRoster.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}