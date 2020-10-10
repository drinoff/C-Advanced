using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
        public Pokemon(string name,string element,int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
}
