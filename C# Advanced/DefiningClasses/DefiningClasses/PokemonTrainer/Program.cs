using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = string.Empty;


            List<Trainer> trainers = new List<Trainer>();
            List<Pokemon> pokemons = new List<Pokemon>();

            while ((cmd = Console.ReadLine()) != "Tournament")
            {
                string[] splitted = cmd
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string trainerName = splitted[0];
                string pokemonName = splitted[1];
                string pokemonElement = splitted[2];
                int pokemonHealth = int.Parse(splitted[3]);

                Pokemon pokemon = new Pokemon
                    (pokemonName, pokemonElement, pokemonHealth);

                bool isTrainerExist = trainers.Any(x => x.Name == trainerName);

                if (isTrainerExist)
                {
                    int index = trainers.FindIndex(x => x.Name == trainerName);
                    trainers[index].Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }

                pokemons.Add(pokemon);
            }
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var item in trainers)
                {
                    

                    if (item.Pokemons.Any(x => x.Element == command))
                    {
                        item.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in item.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                    HealthCheck(item);
                }
            }

            foreach (var item in trainers.OrderByDescending(x=>x.NumberOfBadges))
            {
                Console.WriteLine($"{item.Name} {item.NumberOfBadges} {item.Pokemons.Count}");
            }
        }
        private static void HealthCheck(Trainer currentTrainer)
        {
            for (int i = 0; i < currentTrainer.Pokemons.Count; i++)
            {
                if (currentTrainer.Pokemons[i].Health <= 0)
                {
                    currentTrainer.Pokemons.Remove(currentTrainer.Pokemons[i]);
                }
            }
        }
    }
}
