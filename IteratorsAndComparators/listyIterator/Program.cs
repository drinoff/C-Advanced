using System;
using System.Collections.Generic;
using System.Linq;

namespace listyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            input.RemoveAt(0);
            var list = new List<string>(input);
            var listyIterator = new ListyIterator<string>(list) ;
            

            var nextInput = Console.ReadLine();
            while (nextInput!="END")
            {
                switch (nextInput)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move()); 
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext()); 
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                }
                nextInput = Console.ReadLine();
            }
        }
    }
}
