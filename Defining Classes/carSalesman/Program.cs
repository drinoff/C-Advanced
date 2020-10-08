using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace carSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineCount = int.Parse(Console.ReadLine());
            var engineList = new List<Engine>();
            var carList = new List<Car>();

            for (int i = 0; i < engineCount; i++)
            {
                var engineInfo = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = engineInfo[0];
                var power = int.Parse(engineInfo[1]);
                var displacement = 0;
                var efficiency = string.Empty;
                if(engineInfo.Length == 2)
                {
                    var engine = new Engine(model, power);
                    engineList.Add(engine);
                }
                else if (engineInfo.Length == 4)
                {
                     displacement = int.Parse(engineInfo[2]);
                     efficiency = engineInfo[3];
                    var engine = new Engine(model,power,displacement,efficiency);
                    engineList.Add(engine);
                }
                else
                {
                    var isNotString = int.TryParse(engineInfo[2], out int intResult);
                    if(isNotString == false)
                    {
                         efficiency = engineInfo[2];
                        var engine = new Engine(model, power, efficiency);
                        engineList.Add(engine);
                    }
                    else
                    {
                         displacement = int.Parse(engineInfo[2]);
                        var engine = new Engine(model, power, displacement); 
                        engineList.Add(engine);
                    }
                    
                }
                
                
            }
            var carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                var carInfo = Console.ReadLine()
                                     .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var model = carInfo[0];
                var engine = engineList.Find(x => x.Model == carInfo[1]);
                if(carInfo.Length == 2)
                {
                    var car = new Car(model, engine);
                    carList.Add(car);
                }
                else if(carInfo.Length == 4)
                {
                    var weight = int.Parse(carInfo[2]);
                    var color = carInfo[3];
                    var car = new Car(model, engine, weight, color);
                    carList.Add(car);
                }
                else
                {
                    
                    var isNotString = int.TryParse(carInfo[2], out int result);
                    if(isNotString == false)
                    {
                        var color = carInfo[2];
                        var car = new Car(model, engine, color);
                        carList.Add(car);
                    }
                    else
                    {
                        var weight = int.Parse(carInfo[2]);
                        var car = new Car(model, engine, weight);
                        carList.Add(car);
                    }
                }
            }
            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
