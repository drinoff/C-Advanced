using System;
using System.Collections.Generic;
using System.Linq;

namespace softUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var normalSet = new HashSet<string>();
            var vipSet = new HashSet<string>();
            var input = Console.ReadLine();
            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipSet.Add(input);
                }
                else
                {
                    normalSet.Add(input);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "END")
            {
                if (vipSet.Contains(input))
                {
                    vipSet.Remove(input);
                }
                else if (normalSet.Contains(input))
                {
                    normalSet.Remove(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(vipSet.Count + normalSet.Count);
            foreach (var vip in vipSet)
            {
                Console.WriteLine(vip);
            }
            foreach (var normal in normalSet)
            {
                Console.WriteLine(normal);
            }
        }
    }
}
