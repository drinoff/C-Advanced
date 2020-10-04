using System;
using System.Collections.Generic;
using System.Linq;

namespace findEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> even = x => x % 2 == 0;  
            Predicate<int> odd = x => x % 2 != 0;
            var numbers = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            var minBound = numbers[0];
            var maxBound = numbers[1];
            var command = Console.ReadLine();
            var numberList = new List<int>();
            
            for (int i = minBound; i <= maxBound; i++)
            {
                numberList.Add(i);
            }

            if (command == "even")
            {
            Console.WriteLine(string.Join(" ",numberList.FindAll(even)));
            }

            else
            {
                Console.WriteLine(string.Join(" ", numberList.FindAll(odd)));
            }
        }        
    }
}
