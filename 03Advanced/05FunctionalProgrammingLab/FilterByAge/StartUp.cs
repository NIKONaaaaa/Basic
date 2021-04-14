namespace FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(line[0], int.Parse(line[1])));
            }
            string filterType = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());
            string formatType = Console.ReadLine();
            Func<Person, string, int, bool> filter = FilterByAge;
            foreach (Person person in people.Where(person => filter(person, filterType, ageLimit)))
            {
                Console.WriteLine(Print(person, formatType));
            }
        }
        public static bool FilterByAge(Person person, string filterType, int age)
        {
            return filterType == "younger" && person.Age < age || filterType == "older" && age <= person.Age;
        }
        public static string Print(Person person, string format)
        {
            StringBuilder formatted = new StringBuilder();
            if (format.Split()[0] == "name")
            {
                formatted.Append(person.Name);
                if (1 < format.Split().Length)
                {
                    formatted.Append($" - {person.Age}");
                }
            }
            else
            {
                formatted.Append(person.Age);
            }
            return formatted.ToString();
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
        }
    }
}