using System;
using System.Linq;

namespace sumNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Sum());
        }
    }
}
