using System;
using System.Collections.Generic;
using System.Linq;

namespace addVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToList();
            foreach (var number in numbers)
            {
                AddVat(number);
            }
            
        }
        public static void AddVat(double number) => Console.WriteLine($"{number * 1.2:f2}");



    }
}
