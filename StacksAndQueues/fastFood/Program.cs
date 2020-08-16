using System;
using System.Collections.Generic;
using System.Linq;

namespace fastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodAmount = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var myQueue = new Queue<int>(orders);
            var biggestOrder = myQueue.Max();
            bool wasNotEnough = false;
            var count = myQueue.Count;

            for (int i = 0; i < count; i++)
            {          
                if (foodAmount >= myQueue.Peek())
                {
                    var lastOrder = myQueue.Dequeue();
                    foodAmount -= lastOrder;
                }  
                else
                {
                    wasNotEnough = true;
                    break;
                }
            }
            Console.WriteLine(biggestOrder);
            if(wasNotEnough)
            {
                Console.WriteLine($"Orders left: {string.Join(" ",myQueue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
