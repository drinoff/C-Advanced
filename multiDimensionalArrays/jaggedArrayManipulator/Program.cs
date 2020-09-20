using System;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace jaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var jagged = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = InputLine();
            }
            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    
                    jagged[row] = jagged[row].Select(x => x * 2).ToArray();
                    jagged[row+1] = jagged[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                   jagged[row] = jagged[row].Select(x => x / 2).ToArray();
                    jagged[row+1] = jagged[row + 1].Select(x => x / 2).ToArray();
                }
            }
            var input = Console.ReadLine();
            while (input!= "End")
            {
                var command = input.Split();
                var action = command[0];
                var commandRow = int.Parse(command[1]);
                var commandCol = int.Parse(command[2]);
                var value = int.Parse(command[3]);
                if (commandRow >= 0 && commandRow < rows && commandCol >= 0 && commandCol < jagged[commandRow].Length)
                {
                    switch (action)
                    {
                        case "Add":
                            jagged[commandRow][commandCol] += value;
                            break;
                        case "Subtract":
                            jagged[commandRow][commandCol] -= value;
                            break;
                    }
                }
                input = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ",jagged[row]));
            }
        }
        static double[] InputLine() => Console.ReadLine().Split().Select(double.Parse).ToArray();

        


    }
}
