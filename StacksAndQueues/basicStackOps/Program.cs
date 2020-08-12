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
            var myStack = new Stack<int>(input);

            for (int i = 0; i < integers[1]; i++)
            {
                if (myStack.Any())
                    myStack.Pop();
            }
            if (myStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (myStack.Contains(integers[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(myStack.Min());
                }
            }

        }
    }
}
