using System;
using System.Linq;

namespace sortEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
