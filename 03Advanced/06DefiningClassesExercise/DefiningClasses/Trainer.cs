namespace DefiningClasses
{
    using System.Collections.Generic;
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokedex { get; set; }
        public Trainer()
        {
            Badges = 0;
            Pokedex = new List<Pokemon>();
        }
        public Trainer(string name) : this()
        {
            Name = name;
        }
        internal void AddPokemon(Pokemon pokemon)
        {
            Pokedex.Add(pokemon);
        }
    }
}