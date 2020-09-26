using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace periodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var periodicTable = new HashSet<string>();
            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var input = InputParser();
                for (int j = 0; j < input.Length; j++)
                {                                        
                        periodicTable.Add(input[j]);                    
                }
            }
            Console.WriteLine(string.Join(" ",periodicTable.OrderBy(x=>x)));
        }
        public static string[] InputParser()
        {
            return Console.ReadLine().Split();
        }
        
    }
}
