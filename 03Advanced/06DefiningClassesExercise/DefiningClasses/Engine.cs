﻿namespace DefiningClasses
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
        public Engine()
        {
            Displacement = "n/a";
            Efficiency = "n/a";
        }
        public Engine(string model, int power) : this()
        {
            Model = model;
            Power = power;
        }
    }
}