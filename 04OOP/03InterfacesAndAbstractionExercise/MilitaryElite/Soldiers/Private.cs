namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    public class Private : Soldier, IPrivate
    {
        public decimal Salary { get; set; }

        public Private(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString() => this.PrivateToString();
    }
}