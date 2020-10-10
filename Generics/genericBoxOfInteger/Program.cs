using System;
using System.Collections.Generic;

namespace genericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {                       
                var linesCount = int.Parse(Console.ReadLine());
                var list = new List<Box<int>>();
                for (int i = 0; i < linesCount; i++)
                {
                    var value = int.Parse(Console.ReadLine());
                    var box = new Box<int>(value);
                    list.Add(box);
                }
                foreach (var box in list)
                {
                    Console.WriteLine(box.ToString());
                }
            
        }
    }
}
