using System;
using System.Collections.Generic;
using System.Linq;

namespace printEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var myQueue = new Queue<int>(numbers);

            var evenNums = myQueue.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ",evenNums));
        }
    }
}
