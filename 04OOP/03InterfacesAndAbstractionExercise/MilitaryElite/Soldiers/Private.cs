namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    public class Private : IPrivate
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public Private(string id, string firstName, string lastName, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public override string ToString()
        {
            return this.Stringify();
        }
    }
}