using System;
using System.Collections.Generic;
using System.Linq;

namespace simpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var myStack = new Stack<string>(input.Reverse());
            while (myStack.Count > 1)
            {

                var digit1 = int.Parse(myStack.Pop());
                var operation = myStack.Pop();
                var digit2 = int.Parse(myStack.Pop());

                var result = 0;
                switch (operation)
                {
                    case "+":
                        result = digit1 + digit2;
                        break;
                    case "-":
                        result = digit1 - digit2;
                        break;
                }
                myStack.Push(result.ToString());
            }
            Console.WriteLine(myStack.Pop());
        }
    }
}
