namespace ComparingObjects
{
    using System;
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var nameComparison = this.Name.CompareTo(other.Name);
            if (nameComparison != 0) return nameComparison;
            var ageComparison = Age.CompareTo(other.Age);
            if (ageComparison != 0) return ageComparison;
            return this.Town.CompareTo(other.Town);
        }

    }
}