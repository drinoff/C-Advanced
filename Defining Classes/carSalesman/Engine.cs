using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace carSalesman
{
    class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model,int power)
        {
            Model = model;
            Power = power;
        }
        public Engine(string model,int power,int displacement)
            :this (model,power)
        {
            Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement,string efficiency)
            : this(model, power,displacement)
        {
            Efficiency = efficiency;
        }
        public override string ToString()
        {
            var notApplicable = "n/a";
            if (Displacement == 0)
            {
                if (Efficiency == null)
                {

                    return $"{Model}:" + $"{Environment.NewLine}" +
                           $"  Power: {Power}" + $"{Environment.NewLine}" +
                           $"  Displacement: {notApplicable}" + $"{Environment.NewLine}" +
                           $"  Efficiency: {notApplicable}";
                }
                else
                {
                    return $"{Model}:" + $"{Environment.NewLine}" +
                           $"  Power: {Power}" + $"{Environment.NewLine}" +
                           $"  Displacement: {notApplicable}" + $"{Environment.NewLine}" +
                           $"  Efficiency: {Efficiency}";
                }
            }
            else
            {
                if (Efficiency == null)
                {

                    return $"{Model}:" + $"{Environment.NewLine}" +
                           $"  Power: {Power}" + $"{Environment.NewLine}" +
                           $"  Displacement: {Displacement}" + $"{Environment.NewLine}" +
                           $"  Efficiency: {notApplicable}";
                }
                else
                {
                    return $"{Model}:" + $"{Environment.NewLine}" +
                           $"  Power: {Power}" + $"{Environment.NewLine}" +
                           $"  Displacement: {Displacement}" + $"{Environment.NewLine}" +
                           $"  Efficiency: {Efficiency}";
                }
            }
        }

    }
}
