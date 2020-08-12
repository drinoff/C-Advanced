using System;
using System.Collections.Generic;
using System.Linq;

namespace basicStackOps
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var myQ = new Queue<int>(input);

            for (int i = 0; i < integers[1]; i++)
            {
                if (myQ.Any())
                    myQ.Dequeue();
            }
            if (myQ.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (myQ.Contains(integers[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(myQ.Min());
                }
            }

        }
    }
}

