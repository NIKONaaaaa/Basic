namespace Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; set; }
        public abstract int Power { get; }

        public BaseHero(string name)
        {
            Name = name;
        }

        public abstract string CastAbility();
    }
}