namespace Raiding
{
    public class Druid : BaseHero
    {
        public override int Power => 80;

        public Druid(string name) : base(name)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}