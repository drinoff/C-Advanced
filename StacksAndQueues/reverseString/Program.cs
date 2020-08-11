using System;
using System.Collections.Generic;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(string.Join("", new Stack<char>(Console.ReadLine())));
        }
    }
}
