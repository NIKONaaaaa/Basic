namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; set; }

        public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public override string ToString() => this.Stringify();
    }
}