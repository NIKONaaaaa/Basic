namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;
    public class Commando : ICommando
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Corps { get; set; }
        public List<IMission> Missions { get; set; }

        public Commando(string id, string firstName, string lastName, decimal salary, string soldiers)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = soldiers;
            Missions = new List<IMission>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Stringify());
            sb.AppendLine($"Corps: {Corps}");
            sb.Append("Missions:");

            foreach (var mission in Missions)
            {
                sb.AppendLine();
                sb.Append($"  {mission}");
            }

            return sb.ToString();
        }
    }
}