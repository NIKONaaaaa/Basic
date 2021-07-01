namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    public interface ILieutenantGeneral : IPrivate
    {
        public List<ISoldier> Privates { get; set; }
    }
}