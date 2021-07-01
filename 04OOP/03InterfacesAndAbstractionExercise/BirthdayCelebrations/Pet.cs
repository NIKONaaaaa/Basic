namespace BirthdayCelebrations
{
    public class Pet : IBiological
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string GetBirthYear()
        {
            return $"{Birthdate[^4..]}";
        }
    }
}