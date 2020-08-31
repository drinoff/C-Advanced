using System;
using System.Linq;

namespace jaggedArrMod
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = ParseInput();
            }
            var input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                var command = input.Split();
                var action = command[0];
                var row = int.Parse(command[1]);
                var col = int.Parse(command[2]);
                var value = int.Parse(command[3]);
                if (row > rows - 1 || row < 0 || col < 0 || col > jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (action == "add")
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }

        }
        static int[] ParseInput()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        
    }
}
