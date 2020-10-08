using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace carSalesman
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine, color)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            var notApplicable = "n/a";
            if (Weight == 0)
            {
                if (Color == null)
                {

                    return $"{Model}:" + $"{Environment.NewLine}" +
                           $" {Engine.ToString()}" + $"{Environment.NewLine}" +
                           $" Weight: {notApplicable}" + $"{Environment.NewLine}" +
                           $" Color: {notApplicable}";
                }
                else
                {
                    return $"{Model}:" + $"{Environment.NewLine}" +
                           $" {Engine.ToString()}" + $"{Environment.NewLine}" +
                           $" Weight: {notApplicable}" + $"{Environment.NewLine}" +
                           $" Color: {Color}";
                }
            }
            else
            {
                if (Color == null)
                {

                    return $"{Model}:" + $"{Environment.NewLine}" +
                           $" {Engine.ToString()}" + $"{Environment.NewLine}" +
                           $" Weight: {Weight}" + $"{Environment.NewLine}" +
                           $" Color: {notApplicable}";
                }
                else
                {
                    return $"{Model}:" + $"{Environment.NewLine}" +
                           $" {Engine.ToString()}" + $"{Environment.NewLine}" +
                           $" Weight: {Weight}" + $"{Environment.NewLine}" +
                           $" Color: {Color}";
                }
            }
        }
    }
}
