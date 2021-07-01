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
            sb.Append(this.CommandoToString());

            foreach (var mission in Missions)
            {
                sb.Append($"\r\n  {mission}");
            }

            return sb.ToString();
        }
    }
}