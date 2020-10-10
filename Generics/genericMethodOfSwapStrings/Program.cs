using System;
using System.Collections.Generic;
using System.Linq;

namespace genericMethodOfSwapStrings
{
    class Program
    {
        static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());
            var list = new List<Box<int>>();
            for (int i = 0; i < linesCount; i++)
            {
                var value = int.Parse(Console.ReadLine());
                var box = new Box<int>(value);
                list.Add(box);
            }
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var indexOne = indexes[0];
            var indexTwo = indexes[1];
            list = Swap(list, indexOne, indexTwo);
            foreach (var box in list)
            {
                Console.WriteLine(box.ToString());
            }
        }
        public static List<T> Swap<T>(List<T> list,int indexOne, int indexTwo)
        {
            var temp = list[indexOne];
            list[indexOne] = list[indexTwo];
            list[indexTwo] = temp;
            return list;
        }

    }
}
