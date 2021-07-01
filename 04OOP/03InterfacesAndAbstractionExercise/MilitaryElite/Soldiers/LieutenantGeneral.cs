namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    using System.Collections.Generic;
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<ISoldier> Privates { get; set; }

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            Privates = new List<ISoldier>();
        }

        public override string ToString() => this.Stringify();
    }
}