using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<string>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                if(input == "Paid")
                {
                    while (myQueue.Any())
                    {
                        Console.WriteLine(myQueue.Dequeue());
                    }
                }
                else
                {
                    myQueue.Enqueue(input);
                }
            input = Console.ReadLine();
            }
            Console.WriteLine($"{myQueue.Count} people remaining.");
        }
    }
}
