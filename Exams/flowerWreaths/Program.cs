using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace flowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var liliesInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rosesInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var lilies = new Stack<int>(liliesInput);
            var roses = new Queue<int>(rosesInput);

            var wreathsCount = 0;
            var restFlowers = 0;
            while (lilies.Any() && roses.Any())
            {
                var currLilies = lilies.Peek();
                var currRosses = roses.Peek();
            LoopToReduceFlowers:
                if (currLilies + currRosses == 15)
                {
                    wreathsCount++;
                }
                else if (currLilies + currRosses > 15)
                {
                    currLilies -= 2;
                    goto LoopToReduceFlowers;
                }
                else
                {
                    restFlowers += currLilies + currRosses;
                }
                lilies.Pop();
                roses.Dequeue();
            }
            wreathsCount += restFlowers / 15;
            if (wreathsCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathsCount} wreaths more!");
            }
        }
    }
}
