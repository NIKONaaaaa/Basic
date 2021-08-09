namespace Raiding
{
    public class Warrior : BaseHero
    {
        public override int Power => 100;

        public Warrior(string name) : base(name)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}