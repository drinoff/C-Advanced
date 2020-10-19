using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Parking
{
    class Parking
    {
        private List<Car> data;

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get => this.data.Count;
        }
        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.data = new List<Car>();
        }

        public void Add(Car car)
        {
            if (this.Capacity > this.data.Count)
            {
                this.data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            var forRemoving = this.data.Find(x => x.Manufacturer == manufacturer && x.Model == model);
            if (this.data.Contains(forRemoving))
            {
                this.data.Remove(forRemoving);
                return true;
            }
            return false;
        }
        public Car GetCar(string name, string model)
        {
            var carToGet = this.data.Find(x => x.Manufacturer == name && x.Model == model);
            if (this.data.Contains(carToGet))
            {
                return carToGet;
            }
            else
                return null;
        }
        public Car GetLatestCar()
        {
            if (this.data.Any())
            {
                var oldestCar = this.data.OrderByDescending(x => x.Year).Take(1).ToList();
                return oldestCar[0];
            }
            else
                return null;
        }
        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.Append($"The cars are parked in {this.Type}:" + Environment.NewLine);
            ;
            foreach (var car in this.data)
            {
                sb.Append(car.ToString()+ Environment.NewLine);
            }
            return sb.ToString().Trim();
        }
    }
}
