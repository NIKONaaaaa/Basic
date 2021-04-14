namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            string command = Console.ReadLine();
            int matchCount = 0, mismatchCount = 0;
            while (command != "END")
            {
                string name = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                int age = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToString()[1];
                string town = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2];
                people.Add(new Person(name, age, town));
                command = Console.ReadLine();
            }
            int controlNumber = int.Parse(Console.ReadLine()) - 1;
            Person comparable = people[controlNumber];
            foreach (Person person in people)
            {
                if (person.CompareTo(comparable) != 0)
                {
                    mismatchCount++;
                }
                else if (person.CompareTo(comparable) == 0)
                {
                    matchCount++;
                }
            }
            Console.WriteLine(matchCount <= 1 ? "No matches" : $"{matchCount} {mismatchCount} {people.Count}");
        }
    }
}