using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace evenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var forReplacing = new char[] { '-', ',', '?', '!', '.' };
            var line = new Stack<string>();
            using (var sw = new StreamReader("text.txt"))
            {
                var count = 0;
                while (true)
                {
                    var readedLine = sw.ReadLine();
                    if (readedLine == null)
                    {
                        break;
                    }

                    if (count % 2 == 0)
                    {
                        var replaced = ReplaceChar(readedLine, forReplacing);
                        var reversed = replaced.Split().Reverse();
                        Console.WriteLine(string.Join(" ", reversed));
                    }
                    count++;
                }
            }

        }
        public static string ReplaceChar(string readedLine, char[] forReplacing)
        {
            for (int j = 0; j < forReplacing.Length; j++)
            {
                readedLine = readedLine.Replace(forReplacing[j], '@');
            }

            return readedLine;
        }

    }
}
