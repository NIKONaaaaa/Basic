namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    public interface ILieutenantGeneral : IPrivate
    {
        public List<IPrivate> Privates { get; set; }
    }
}