using System;
using System.Collections.Generic;
using System.Linq;

namespace maximumAndMinimumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandCount = int.Parse(Console.ReadLine());
            var myStack = new Stack<int>();
            for (int i = 0; i < commandCount; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var action = input[0];
                switch(action)
                {
                    case 1:
                        var element = input[1];
                        myStack.Push(element);
                        break;
                    case 2:
                        myStack.Pop();
                        break;
                    case 3:
                        if (myStack.Any())
                        {
                            Console.WriteLine(myStack.Max());
                        }
                        break;
                    case 4:
                        if(myStack.Any())
                        {
                        Console.WriteLine(myStack.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",myStack));
        }
    }
}
