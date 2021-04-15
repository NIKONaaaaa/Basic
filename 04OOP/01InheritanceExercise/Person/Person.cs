namespace Person
{
    using System;
    using System.Text;
    public class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder personInfo = new StringBuilder();
            personInfo.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return personInfo.ToString();
        }
    }
}