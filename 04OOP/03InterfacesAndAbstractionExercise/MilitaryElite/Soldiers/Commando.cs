namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;
    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<IMission> Missions { get; set; }

        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
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