using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] comm = Console.ReadLine().Split();
            List<Trainer> trainers = new List<Trainer>();

            while (comm[0] != "Tournament")
            {
                Fill(trainers, comm);
                comm = Console.ReadLine().Split();
            }

            comm = Console.ReadLine().Split();

            while (comm[0] != "End")
            {
                Battle(trainers, comm[0]);
                comm = Console.ReadLine().Split();
            }
            trainers.OrderByDescending(x => x.NumOfBadges).ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.NumOfBadges} {x.Pokemons.Count}"));
        }
        public static void Fill(List<Trainer> trainers, string[] comm)
        {
            if (trainers.Exists(x => x.Name == comm[0]))
            {
                Pokemon pokemon = new Pokemon(comm[1], comm[2], Convert.ToDouble(comm[3]));
                trainers.Find(x => x.Name == comm[0]).Pokemons.Add(pokemon);
            }
            else
            {
                Trainer trainer = new Trainer(comm[0], new List<Pokemon>());
                trainers.Add(trainer);
                Pokemon pokemon = new Pokemon(comm[1], comm[2], Convert.ToDouble(comm[3]));
                trainers.Find(x => x == trainer).Pokemons.Add(pokemon);
            }
        }
        public static void Battle(List<Trainer> trainers, string element)
        {
            foreach (Trainer trainer in trainers)
            {
                if (trainer.Pokemons.Exists(x => x.Element == element))
                {
                    trainer.NumOfBadges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(x => x.Health -= 10);
                    trainer.Pokemons = trainer.Pokemons.Where(x => x.Health > 0).ToList();
                }
            }
        }
    }
}
