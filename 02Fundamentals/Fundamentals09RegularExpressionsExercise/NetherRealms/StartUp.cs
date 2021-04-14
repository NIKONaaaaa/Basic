namespace NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            List<Demon> demons = new List<Demon>();
            string textInput = Console.ReadLine();
            string[] demonsNames = textInput.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            const string healthPattern = @"[^0-9+*\/.-]", baseDamagePattern = @"[+-]?(?:(?:\d+\.\d+)|(?:\d+))", damageBonusPattern = @"[*\/]";
            foreach (string input in demonsNames)
            {
                int health = 0;
                {
                    MatchCollection matches = Regex.Matches(input, healthPattern);
                    foreach (Match match in matches)
                    {
                        health += char.Parse(match.Value);
                    }
                }
                double damage = 0;
                {
                    MatchCollection matches = Regex.Matches(input, baseDamagePattern);
                    foreach (Match match in matches)
                    {
                        damage += double.Parse(match.Value);
                    }
                    MatchCollection damageBonus = Regex.Matches(input, damageBonusPattern);
                    foreach (Match match in damageBonus)
                    {
                        if (match.Value == "*")
                        {
                            damage *= 2;
                        }
                        else
                        {
                            damage /= 2;
                        }
                    }
                }
                demons.Add(new Demon(input, health, damage));
            }
            foreach (Demon demon in demons.OrderBy(name => name.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
    }
}