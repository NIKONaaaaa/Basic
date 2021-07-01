namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    using System.Collections.Generic;
    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<IMission> Missions { get; set; }

        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public override string ToString() => this.CommandoToString();
    }
}