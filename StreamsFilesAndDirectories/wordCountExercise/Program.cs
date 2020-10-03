using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace wordCountExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllLines("../../../words.txt");
            var separator = new char[] { '!', '?', '.', ',', '-', ' ' };
            var text = File.ReadAllText("../../../text.txt")
                           .ToLower()
                           .Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var wordMatches = new Dictionary<string, int>();
            var counter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == (words[i]))
                    {
                        counter++;
                    }
                }
                wordMatches.Add(words[i], counter);
                counter = 0;
            }
            foreach (var word in wordMatches)
            {
                File.AppendAllText("../../../actualResult.txt", $"{word.Key} - {word.Value}" + Environment.NewLine);
            }
            wordMatches = wordMatches.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,y=>y.Value);
            foreach (var item in wordMatches)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
