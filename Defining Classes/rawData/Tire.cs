using System;
using System.Collections.Generic;
using System.Text;

namespace rawData
{
    class Tire
    {
        public double Pressure { get; set; }
        public double Age { get; set; }

        public Tire(double pressure,int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }

}
