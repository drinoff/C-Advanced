using System;
using System.Collections.Generic;
using System.Linq;

namespace tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine().Split();
            var value = input[0] +" "+ input[1];
            var secondValue = input[2];
            var tuple = new Tuple<string, string>(value, secondValue);
            Console.WriteLine(tuple.ToString());

            input = Console.ReadLine().Split();
            value = input[0];
            var ssecondValue = int.Parse(input[1]);
            var secondTuple = new Tuple<string, int>(value, ssecondValue);
            Console.WriteLine(secondTuple.ToString());

            input = Console.ReadLine().Split();
            var doubleOne = int.Parse(input[0]);
            var doubleTwo = double.Parse(input[1]);
            var thirdTuple = new Tuple<int, double>(doubleOne, doubleTwo);
            Console.WriteLine(thirdTuple.ToString());

        }
    }
}
