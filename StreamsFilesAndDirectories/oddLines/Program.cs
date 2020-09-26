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
            int lineCount = 0;
            while (true)
            {
                var currentLine = sr.ReadLine();
                if (currentLine == null)
                {
                    break;
                }
                if(lineCount%2 !=0)
                {
                    sw.WriteLine(currentLine);
                    sw.Flush();
                }                
                lineCount++;
            }
        }
    }
}
