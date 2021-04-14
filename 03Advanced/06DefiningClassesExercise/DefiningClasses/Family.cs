namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;
    public class Family
    {
        List<Person> People = new List<Person>();
        internal void AddMember(string name, int age)
        {
            Person person = new Person(name, age);
            People.Add(person);
        }
        internal Person GetOldestMember()
        {
            return People.OrderByDescending(m => m.Age).FirstOrDefault();
        }
    }
}