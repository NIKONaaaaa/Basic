namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input = Console.ReadLine();
            while (input != "Tournament")
            {
                string[] split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = split[0];
                string pokemonName = split[1];
                string pokemonElement = split[2];
                int pokemonHealth = int.Parse(split[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                trainers[trainerName].AddPokemon(pokemon);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                foreach (Trainer trainer in trainers.Values)
                {
                    if (trainer.Pokedex.Any(pokemon => pokemon.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokedex.ForEach(pokemon => pokemon.Health -= 10);
                        trainer.Pokedex.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (Trainer trainer in trainers.Values.OrderByDescending(trainer => trainer.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokedex.Count}");
            }
        }
    }
}