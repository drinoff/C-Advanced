using System;
using System.Linq;

namespace knightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(new Action<string>(name => Console.WriteLine($"Sir {name}")));
        }
    }
}
