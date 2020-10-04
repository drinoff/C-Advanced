using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace appliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine();
            
            
            while (input != "end")
            {
                Func<List<int>, List<int>> command = input switch
                {
                    "add" => command = Add,
                    "subtract" => command = Subtract,
                    "multiply" => command = Multiply,
                    _ => command = Print
                };

                command(numbers);
                

                input = Console.ReadLine();
            }
        }
        public static List<int> Add(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] += 1;
            }
            return numbers;
        }
        public static List<int> Subtract(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= 1;
            }
            return numbers;
        }
        public static List<int> Multiply(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= 2;
            }
            return numbers;
        }
        public static List<int> Print(List<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
            return numbers;
        }
         
    }
}
