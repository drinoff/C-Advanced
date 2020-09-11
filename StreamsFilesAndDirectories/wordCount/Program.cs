using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("words.txt");
            var srTwo = new StreamReader("text.txt");
            var sw = new StreamWriter("output.txt");
            var result = new Dictionary<string, int>();

            var separator = new string[] { " ", ", ", ".", "?", "!", "-" };
            var text = srTwo.ReadToEnd().ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var count = 0;
            while (true)
            {
                var currentLine = sr.ReadLine();
                if (currentLine == null)
                {
                    break;
                }
                var words = currentLine.Split();
                for (int i = 0; i < words.Length; i++)
                {
                    for (int  j= 0; j < text.Length; j++)
                    {
                        if(words[i] == text[j])
                        {
                            count++;
                        }
                    }                                      
                    result.Add(words[i], count);
                    count = 0;
                }

            }
            foreach (var word in result.OrderByDescending(x=>x.Value))
            {
                sw.WriteLine($"{word.Key} - {word.Value}");
                sw.Flush();
            }
        }
    }
}
