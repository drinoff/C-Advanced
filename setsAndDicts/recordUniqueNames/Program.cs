using System;
using System.Collections.Generic;

namespace recordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNames = new HashSet<string>();
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var name = Console.ReadLine();
                setNames.Add(name);
            }
            Console.WriteLine(string.Join(Environment.NewLine, setNames));
        }
    }
}
