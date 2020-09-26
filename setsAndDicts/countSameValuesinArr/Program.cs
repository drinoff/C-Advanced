using System;
using System.Collections.Generic;
using System.Linq;

namespace countSameValuesinArr
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<double, int>();

            var input = InputParser();

            for (int i = 0; i < input.Length; i++)
            {
                if(!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], 1);
                }
                else
                {
                    dict[input[i]]++;
                }
            }
            foreach (var element in dict)
            {
                Console.WriteLine($"{element.Key} - {element.Value} times");
            }
        }
        public static  int[] InputParser() => Console.ReadLine().Split().Select(int.Parse).ToArray();
    }
}
