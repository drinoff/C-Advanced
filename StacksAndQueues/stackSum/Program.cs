using System;
using System.Collections.Generic;
using System.Linq;

namespace stackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var myStack = new Stack<int>(numbers);
            var input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                var command = input.Split();
                var action = command[0];
                switch (action)
                {
                    case "add":
                        var digit1 = int.Parse(command[1]);
                        var digit2 = int.Parse(command[2]);
                        myStack.Push(digit1);
                        myStack.Push(digit2);
                        break;
                    case "remove":
                        var count = int.Parse(command[1]);
                        if (myStack.Count >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                myStack.Pop();
                            }
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum: {myStack.Sum()}");
        }
    }
}
