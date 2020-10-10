using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace pokemon
{
    class Trainers
    {
        public string Name { get; set; }
        public int Badges = 0;
        public List<Pokemon> Pokemons = new List<Pokemon>();
        public Trainers(string name, Pokemon pokemon)
        {
            Name = name;
            Pokemons.Add(pokemon);
        }
        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
        
    }


}
