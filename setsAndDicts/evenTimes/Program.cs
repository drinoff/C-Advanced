using System;
using System.Collections.Generic;
using System.Linq;

namespace evenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sameIntCounter = new Dictionary<int,int>();

            var intCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < intCount; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if(!sameIntCounter.ContainsKey(input))
                {
                    sameIntCounter.Add(input, 0);
                }
                sameIntCounter[input] += 1;

            }

            foreach (var item in sameIntCounter.Where(x=>x.Value %2 == 0))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
