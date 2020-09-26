using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Schema;

namespace speedRacing
{
    class Car
    {
        public Car(string model,double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public static List<Car> Drive(List<Car> carList,string carModel, double amountOfKM)
        {
            var drivenCar = carList.Find(x => x.Model == carModel);
            var neededFuel = amountOfKM*drivenCar.FuelConsumptionPerKilometer;
            if(neededFuel>drivenCar.FuelAmount)
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                drivenCar.TravelledDistance += amountOfKM;
                drivenCar.FuelAmount -= neededFuel;
            }
            return carList;
        }
        public override string ToString()
        {
            return $"{ this.Model} { this.FuelAmount:f2} {this.TravelledDistance:f0}";
        }
    }
}
