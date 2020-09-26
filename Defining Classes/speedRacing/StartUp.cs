using System;
using System.Collections.Generic;
using System.Linq;

namespace speedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var carList = new List<Car>();
            var input = InputParser();
            var carCount = int.Parse(input[0]);

            for (int i = 0; i < carCount; i++)
            {
                input = InputParser();
                var model = input[0];
                var fuelAmount = double.Parse(input[1]);
                var fuelConsumtionPerKM = double.Parse(input[2]);
                var car = new Car(model,fuelAmount,fuelConsumtionPerKM);
                if(!carList.Contains(car))
                {
                carList.Add(car);
                }
            }

            input = InputParser();
            while (!input.Contains("End"))
            {
                var carModel = input[1];
                var amountOfKM = double.Parse(input[2]);
                Car.Drive(carList, carModel, amountOfKM);
                input = InputParser();
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }
            
        }
       
        public static string[] InputParser()
        {
            return Console.ReadLine().Split();
        }
    }
}
