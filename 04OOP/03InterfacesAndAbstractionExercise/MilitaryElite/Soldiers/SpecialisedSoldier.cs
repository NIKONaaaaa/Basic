namespace MilitaryElite.Soldiers
{
    using Interfaces;
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string Corps { get; set; }

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }
    }
}