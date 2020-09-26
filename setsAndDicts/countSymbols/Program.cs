using System;
using System.Collections.Generic;
using System.Linq;

namespace countSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            var charCounter = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if(!charCounter.ContainsKey(text[i]))
                {
                    charCounter.Add(text[i], 0);
                }
                charCounter[text[i]] += 1;
            }
            foreach (var item in charCounter.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");

            }
        }
    }
}
