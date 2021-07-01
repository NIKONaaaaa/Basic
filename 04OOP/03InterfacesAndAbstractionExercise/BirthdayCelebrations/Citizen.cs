namespace BirthdayCelebrations
{
    public class Citizen : IBiological, IPerson, IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string GetBirthYear()
        {
            return $"{Birthdate[^4..]}";
        }
    }
}