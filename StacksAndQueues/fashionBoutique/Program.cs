using System;
using System.Collections.Generic;
using System.Linq;

namespace fashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rackCapacity = int.Parse(Console.ReadLine());
            var temp = rackCapacity;
            var myStack = new Stack<int>(clothesValue);
            var rackCount = 1;

            while (myStack.Any())
            {
                var topValue = myStack.Peek();
                if(rackCapacity>=topValue)
                {
                    rackCapacity -= topValue;
                    myStack.Pop();
                }
                else
                {
                    rackCount++;
                    rackCapacity = temp;
                    rackCapacity -= topValue;
                    myStack.Pop();
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
