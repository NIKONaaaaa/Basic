namespace Raiding
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            int heroNumber = int.Parse(Console.ReadLine());
            List<BaseHero> raidMembers = new List<BaseHero>();
            while (raidMembers.Count < heroNumber)
            {
                try
                {
                    string name = Console.ReadLine();
                    string type = Console.ReadLine();
                    raidMembers.Add(HeroCreator.NewHero(type, name));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            foreach (BaseHero hero in raidMembers)
            {
                Console.WriteLine(hero.CastAbility());
                bossPower -= hero.Power;
            }

            Console.WriteLine(0 < bossPower ? "Defeat..." : "Victory!");
        }
    }
}