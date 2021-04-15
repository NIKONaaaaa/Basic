﻿namespace PlayersAndMonsters
{
    public class Hero
    {
        public string Username { get; set; }
        public int Level { get; set; }

        public Hero(string name, int level)
        {
            this.Username = name;
            this.Level = level;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}