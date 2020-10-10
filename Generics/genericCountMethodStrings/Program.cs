using System;
using System.Collections.Generic;
using System.Linq;

namespace genericCountMethodStrings
{
    public class Program
    {
        static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());
            var list = new List<double>();
            for (int i = 0; i < linesCount; i++)
            {
                var value = double.Parse(Console.ReadLine());

                list.Add(value);
            }
            var box = new Box<double>(list);
            var toCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.ComparerByValue(box.List,toCompare));
        }

    }
}
