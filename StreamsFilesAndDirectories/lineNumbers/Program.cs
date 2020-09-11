using System;
using System.IO;
using System.Text;

namespace oddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("input.txt");
            var sw = new StreamWriter("output.txt");
            var sb = new StringBuilder();
            int lineCount = 1;
            while (true)
            {
                var currentLine = sr.ReadLine();
                if (currentLine == null)
                {
                    break;
                }
                sb.Append(lineCount.ToString());
                sb.Append(". ");
                sb.Append(currentLine);

                sw.WriteLine(sb);
                sw.Flush();
                sb.Clear();
                lineCount++;
            }
        }
    }
}