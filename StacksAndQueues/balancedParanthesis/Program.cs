using System;
using System.Linq;
using System.Collections.Generic;

namespace balancedParanthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var paranthesis = Console.ReadLine();

            var openingBrackets = new Stack<char>();
            var brackets = new Stack<char>(paranthesis.Reverse());

            while (brackets.Any())
            {
                var currentBracket = brackets.Pop();
                if(openingBrackets.Any() && currentBracket == ')' && openingBrackets.Peek() == '(')
                {
                    openingBrackets.Pop();
                    continue;
                }
                else if(openingBrackets.Any() && currentBracket == '}' && openingBrackets.Peek() == '{')
                {
                    openingBrackets.Pop();
                    continue;
                }
                else if(openingBrackets.Any() && currentBracket == ']' && openingBrackets.Peek() == '[')
                {
                    openingBrackets.Pop();
                    continue;
                }
                else
                {
                openingBrackets.Push(currentBracket);
                }

            }
            if(openingBrackets.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }   
    }
}
