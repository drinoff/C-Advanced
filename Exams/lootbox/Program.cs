using System;
using System.Collections.Generic;
using System.Linq;

namespace lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var lootBoxOne = new Queue<int>(InputParser());
            var lootBoxTwo = new Stack<int>(InputParser());
            var itemCollection = new List<int>();

            while (!(lootBoxOne.Count == 0 || lootBoxTwo.Count == 0))
            {
                var currBoxOne = lootBoxOne.Peek();
                var currBoxTwo = lootBoxTwo.Peek();
                var sumBox = currBoxOne + currBoxTwo;
                if (IsEven(sumBox))
                {
                    itemCollection.Add(sumBox);
                    lootBoxOne.Dequeue();
                    lootBoxTwo.Pop();
                }
                else
                {
                    lootBoxOne.Enqueue(currBoxTwo);
                    lootBoxTwo.Pop();
                }
            }
            if(!lootBoxOne.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if(itemCollection.Sum()>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {itemCollection.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {itemCollection.Sum()}");
            }
        }
        public static int[] InputParser() => Console.ReadLine()
                                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse)
                                                    .ToArray();
        public static bool IsEven(int sumBox) => sumBox % 2 == 0;

        
    }
}
