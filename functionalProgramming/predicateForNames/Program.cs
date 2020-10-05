using System;
using System.Collections.Generic;
using System.Linq;

namespace predicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = int.Parse(Console.ReadLine());
            Func<string, bool> nameFilter = x => x.Length <= filter;
            Console.ReadLine()
                   .Split()
                   .Where(nameFilter)
                   .ToList()
                   .ForEach(Console.WriteLine);
                               
                           
        }               
    }
}
