namespace Animals
{
    using System.Text;
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            StringBuilder animalInfo = new StringBuilder();
            animalInfo.AppendLine(GetType().Name);
            animalInfo.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            animalInfo.AppendLine(this.ProduceSound());
            return animalInfo.ToString();
        }
    }
}