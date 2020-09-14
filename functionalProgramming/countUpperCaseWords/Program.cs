using System;
using System.Linq;

namespace countUpperCaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where(x => char.IsUpper(x[0]))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
