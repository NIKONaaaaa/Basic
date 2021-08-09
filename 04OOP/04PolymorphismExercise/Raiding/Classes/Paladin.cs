namespace Raiding
{
    public class Paladin : BaseHero
    {
        public override int Power => 100;

        public Paladin(string name) : base(name)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}