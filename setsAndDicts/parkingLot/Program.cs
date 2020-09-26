using System;
using System.Collections.Generic;
using System.Linq;

namespace parkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new HashSet<string>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                var command = input.Split(", ");
                var direction = command[0];
                var carPlate = command[1];
                switch (direction)
                {
                    case "IN":
                        parkingLot.Add(carPlate);
                        break;
                    case "OUT":
                        parkingLot.Remove(carPlate);
                        break;
                }
                input = Console.ReadLine();
            }
            if (parkingLot.Any())
            {
                foreach (var plate in parkingLot)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
