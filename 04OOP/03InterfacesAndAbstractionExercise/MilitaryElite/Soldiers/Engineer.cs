namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engineer : IEngineer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Corps { get; set; }
        public List<IRepair> Repairs { get; set; }

        public Engineer(string id, string firstName, string lastName, decimal salary, string soldiers)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = soldiers;
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