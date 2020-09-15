using System;
using System.Collections.Generic;
using System.Linq;

namespace simpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = string.Empty;
            var count = int.Parse(Console.ReadLine());
            var myStack = new Stack<string>();
            var opStack = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];
                switch (command)
                {
                    case "1":
                        var toAppend = input[1];
                        text += toAppend;
                        myStack.Push(toAppend);
                        opStack.Push(1);
                        break;
                    case "2":
                        var toErase = int.Parse(input[1]);
                        var toPush = text.TakeLast(toErase).ToList();
                        var toPush2 = string.Join("", toPush);
                        text = text.Remove(text.Length - toErase);
                        myStack.Push(toPush2);
                        opStack.Push(2);
                        break;
                    case "3":
                        var index = int.Parse(input[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case "4":
                        if (opStack.Any() && myStack.Any())
                        {
                            var operation = opStack.Pop();
                            var action = myStack.Pop();

                            if (operation == 1)
                            {
                                text = text.Replace(action, "");
                            }
                            else
                            {
                                text += action;
                            }
                        }
                        
                        break;
                }
            }
        }
    }
}
