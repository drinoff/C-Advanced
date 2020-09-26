using System;
using System.Collections.Generic;

namespace wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < linesCount; i++)
            {
                var input = InputParser(" -> ", ",");
                var color = input[0];
                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 1; j < input.Length; j++)
                {
                    if(!wardrobe[color].ContainsKey(input[j]))
                    {
                    wardrobe[color].Add(input[j], 0);
                    }
                    wardrobe[color][input[j]] += 1;
                }
            }
            var toFind = InputParser(" ");
            var colorToFind = toFind[0];
            var item = toFind[1];

            
            foreach (var colour in wardrobe)
            {
                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var cloth in colour.Value)
                {
                    if (colour.Key == colorToFind)
                    {
                        if (cloth.Key == item)
                        {
                            Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");

                        }
                    }
                    else
                    {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }

            }
        }
        public static string[] InputParser(params string[] separator)
        {

            return Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
