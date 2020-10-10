using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace genericsBoxOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());
            var list = new List<Box<string>>();
            for (int i = 0; i < linesCount; i++)
            {
                var value = Console.ReadLine();
                var box = new Box<string>(value);
                list.Add(box);
            }
            foreach (var box in list)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
