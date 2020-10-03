using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lineNumbersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = File.ReadAllText("../../../text.txt");
            var splittedText = line.Split(System.Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var punctCounter = 0;
            var letterCounter = 0;
            var whiteSpace = 0;
            var punctoation = new List<char> { '!', '?', '.', ',', '-', '\'' };


            for (int i = 0; i < splittedText.Length; i++)
            {
                var currLine = splittedText[i];
                for (int j = 0; j < currLine.Length; j++)
                {
                    if (punctoation.Contains(currLine[j]))
                    {
                        punctCounter++;
                    }

                    else if (currLine[j] == ' ')
                    {
                        whiteSpace++;
                    }

                    else
                    {
                        letterCounter++;
                    }
                }


                File.AppendAllText("../../../output.txt",
                    $"Line {i + 1}: {currLine}({letterCounter})({punctCounter})" + Environment.NewLine);
                letterCounter = 0;
                punctCounter = 0;
                whiteSpace = 0;
            }

        }
    }
}
