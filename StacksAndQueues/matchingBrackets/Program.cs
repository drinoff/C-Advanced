using System;
using System.Collections.Generic;
using System.Linq;

namespace matchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var myStack = new Stack<int>();
            
            for (int i = 0; i < input.Length; i++)
            {                           
                if(input[i] == '(')
                {
                    myStack.Push(i);
                }
                else if(input[i] == ')')
                {
                    var openingBracketIndex = myStack.Pop();
                    Console.WriteLine(input.Substring(openingBracketIndex,(i-openingBracketIndex)+1));
                }
            }
        }
    }
}
