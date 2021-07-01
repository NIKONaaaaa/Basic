namespace MilitaryElite.Soldiers
{
    using Extensions;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<IPrivate> Privates { get; set; }

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Stringify());
            sb.Append(Environment.NewLine);
            sb.Append("Privates:");

            foreach (var prvt in Privates)
            {
                sb.Append(Environment.NewLine);
                sb.Append($"  {prvt.Stringify()}");
            }

            return sb.ToString();
        }
    }
}