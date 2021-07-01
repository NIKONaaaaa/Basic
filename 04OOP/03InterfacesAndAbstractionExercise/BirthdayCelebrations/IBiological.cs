namespace BirthdayCelebrations
{
    public interface IBiological
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }

        public string GetBirthYear();
    }
}