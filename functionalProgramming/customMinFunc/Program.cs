using System;
using System.Linq;

namespace customMinFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[],int> minNumber = MinNumber => numbers.Min();
            Console.WriteLine(minNumber(numbers));
        }
        
    }
}
