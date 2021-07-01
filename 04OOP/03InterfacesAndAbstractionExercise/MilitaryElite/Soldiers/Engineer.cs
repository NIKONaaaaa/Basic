namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<IRepair> Repairs { get; set; }

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<IRepair>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.EngineerToString());
            
            foreach (var repair in Repairs)
            {
                sb.Append($"\r\n  {repair}");
            }

            return sb.ToString();
        }
    }
}