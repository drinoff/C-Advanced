using System;
using System.Collections.Generic;
using System.Text;

namespace rawData
{
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
    
}
