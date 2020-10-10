using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainerList = new List<Trainers>();
            var input = InputParser();
            while (!input.Contains("Tournament"))
            {
                var trainerName = input[0];
                var pokemonName = input[1];
                var pokemonElement = input[2];
                var pokemonHealth = int.Parse(input[3]);

                var pokemon = InitPokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainerList.Any(x => x.Name == trainerName))
                {
                    var trainer = InitTrainers(trainerName, pokemon);
                    trainerList.Add(trainer);
                }
                else
                {

                    var currTrainer = trainerList.Find(x => x.Name == trainerName);
                    currTrainer.Pokemons.Add(pokemon);
                }

                input = InputParser();
            }
            input = InputParser();
            while (!input.Contains("End"))
            {
                var element = input[0];

                trainerList = CheckElement(element, trainerList);
                input = InputParser();
            }

            foreach (var trainer in trainerList.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine(trainer.ToString());
            }

        }
        public static string[] InputParser() => Console.ReadLine().Split();

        public static Pokemon InitPokemon(string pokemonName, string pokemonElement, int pokemonHealth)
            => new Pokemon(pokemonName, pokemonElement, pokemonHealth);

        public static Trainers InitTrainers(string trainerName, Pokemon pokemon)
            => new Trainers(trainerName, pokemon);

        public static List<Trainers> CheckElement(string element, List<Trainers> trainerList)
        {
            switch (element)
            {
                case "Fire":
                    for (int i = 0; i < trainerList.Count; i++)
                    {
                        if (trainerList[i].Pokemons.Any(x => x.Element == "Fire"))
                        {
                            trainerList[i].Badges++;
                        }
                        else
                        {
                            for (int j = 0; j < trainerList[i].Pokemons.Count; j++)
                            {
                                trainerList[i].Pokemons[j].Health -= 10;
                                if (trainerList[i].Pokemons[j].Health <= 0)
                                {
                                    trainerList[i].Pokemons.RemoveAt(j);
                                }
                            }

                        }
                    }
                    break;
                case "Water":
                    for (int i = 0; i < trainerList.Count; i++)
                    {
                        if (trainerList[i].Pokemons.Any(x => x.Element == "Water"))
                        {
                            trainerList[i].Badges++;
                        }
                        else
                        {
                            for (int j = 0; j < trainerList[i].Pokemons.Count; j++)
                            {
                                trainerList[i].Pokemons[j].Health -= 10;
                                if (trainerList[i].Pokemons[j].Health <= 0)
                                {
                                    trainerList[i].Pokemons.RemoveAt(j);
                                }
                            }
                        }
                    }
                    break;
                case "Electricity":
                    for (int i = 0; i < trainerList.Count; i++)
                    {
                        if (trainerList[i].Pokemons.Any(x => x.Element == "Electricity"))
                        {
                            trainerList[i].Badges++;
                        }
                        else
                        {
                            for (int j = 0; j < trainerList[i].Pokemons.Count; j++)
                            {
                                trainerList[i].Pokemons[j].Health -= 10;
                                if (trainerList[i].Pokemons[j].Health <= 0)
                                {
                                    trainerList[i].Pokemons.RemoveAt(j);
                                }
                            }
                        }
                    }
                    break;
            }

            return trainerList;
        }
    }
}
