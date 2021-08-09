namespace Raiding
{
    public class Rogue : BaseHero
    {
        public override int Power => 80;

        public Rogue(string name) : base(name)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}