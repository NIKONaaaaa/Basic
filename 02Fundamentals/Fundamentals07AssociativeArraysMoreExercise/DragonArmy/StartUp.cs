namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();
            int dragonNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < dragonNumber; i++)
            {
                string[] dragon = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = dragon[0], name = dragon[1], damageInput = dragon[2], healthInput = dragon[3], armourInput = dragon[4];
                if (damageInput == "null") damageInput = "45";
                if (healthInput == "null") healthInput = "250";
                if (armourInput == "null") armourInput = "10";
                decimal damage = decimal.Parse(damageInput), health = decimal.Parse(healthInput), armour = decimal.Parse(armourInput);
                if (dragons.ContainsKey(type))
                {
                    if (dragons[type].Any(dragon => dragon.Name == name))
                    {
                        dragons[type].Single(dragon => dragon.Name == name).OverwriteStats(damage, health, armour);
                    }
                    else
                    {
                        dragons[type].Add(new Dragon(name, damage, health, armour));
                    }
                }
                else
                {
                    dragons.Add(type, new List<Dragon>());
                    dragons[type].Add(new Dragon(name, damage, health, armour));
                }
            }
            foreach (var (type, name) in dragons)
            {
                Console.WriteLine($"{type}::({name.Average(name => name.Damage):f2}/{name.Average(name => name.Health):f2}/{name.Average(name => name.Armour):f2})");
                foreach (var dragon in name.OrderBy(alphabet => alphabet.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armour}");
                }
            }
        }
    }
    class Dragon
    {
        public string Name { get; set; }
        public decimal Damage { get; set; }
        public decimal Health { get; set; }
        public decimal Armour { get; set; }
        public Dragon(string name, decimal damage, decimal health, decimal armour)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armour = armour;
        }
        internal void OverwriteStats(decimal damage, decimal health, decimal armour)
        {
            Damage = damage;
            Health = health;
            Armour = armour;
        }
    }
}