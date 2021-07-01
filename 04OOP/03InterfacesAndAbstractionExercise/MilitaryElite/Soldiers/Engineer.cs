namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    using System;
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
            sb.AppendLine(this.Stringify());
            sb.AppendLine($"Corps: {Corps}");
            sb.Append("Repairs:");

            foreach (var repair in Repairs)
            {
                sb.Append(Environment.NewLine);
                sb.AppendJoin(Environment.NewLine, $"  {repair}");
            }

            return sb.ToString();
        }
    }
}