namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    public class Spy : ISpy
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CodeNumber { get; set; }

        public Spy(string id, string firstName, string lastNAme, int codeNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastNAme;
            CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return this.Stringify();
        }
    }
}