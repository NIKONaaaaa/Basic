namespace Raiding
{
    using System;
    public class HeroCreator
    {
        public static BaseHero NewHero(string type, string name)
        {
            switch (type)
            {
                case "Druid":
                    Druid newDruid = new Druid(name);
                    return newDruid;
                case "Paladin":
                    Paladin newPaladin = new Paladin(name);
                    return newPaladin;
                case "Rogue":
                    Rogue newRogue = new Rogue(name);
                    return newRogue;
                case "Warrior":
                    Warrior newWarrior = new Warrior(name);
                    return newWarrior;
                default:
                    throw new Exception("Invalid hero!");
            }
        }
    }
}