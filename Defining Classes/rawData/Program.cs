using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace rawData
{
    class Program
    {
        static void Main(string[] args)
        {
            var carCount = int.Parse(Console.ReadLine());
            var carList = new List<Car>();

            for (int i = 0; i < carCount; i++)
            {
                var carInfo = Console.ReadLine()
                                     .Split();
                var model = carInfo[0];
                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                var tyre1Pressure = double.Parse(carInfo[5]);
                var tyre1Age = int.Parse(carInfo[6]);
                var tyre2Pressure = double.Parse(carInfo[7]);
                var tyre2Age = int.Parse(carInfo[8]);
                var tyre3Pressure = double.Parse(carInfo[9]);
                var tyre3Age = int.Parse(carInfo[10]);
                var tyre4Pressure = double.Parse(carInfo[11]);
                var tyre4Age = int.Parse(carInfo[12]);

                var tires = new List<Tire> { new Tire (tyre1Pressure,tyre1Age), new Tire(tyre2Pressure, tyre2Age),
                new Tire (tyre3Pressure,tyre3Age),new Tire (tyre4Pressure,tyre4Age)};

                var car = new Car(model, new Engine(engineSpeed,enginePower), new Cargo(cargoWeight,cargoType), tires);
                carList.Add(car);
            }
            var filter = Console.ReadLine();
            
            if(filter == "fragile")
            {
                var result = carList.Where(x => x.Cargo.Type == "fragile")
                                    .Where(x => x.Tires.Any(x => x.Pressure < 1));
                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                var result = carList.Where(x => x.Cargo.Type == "flamable")
                                    .Where(x => x.Engine.Power > 250);
                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
            }
            
        }
    }
}
