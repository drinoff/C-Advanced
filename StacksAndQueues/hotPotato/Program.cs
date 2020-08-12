using System;
using System.Collections.Generic;

namespace hotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var childs = Console.ReadLine().Split();
            var myQueue = new Queue<string>(childs);
            var n = int.Parse(Console.ReadLine());

            while (myQueue.Count != 1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    var nonNthChild = myQueue.Dequeue();
                    myQueue.Enqueue(nonNthChild);
                }
                Console.WriteLine($"Removed {myQueue.Dequeue()}");
            }
            Console.WriteLine($"Last is {myQueue.Dequeue()}");
        }
    }
}
