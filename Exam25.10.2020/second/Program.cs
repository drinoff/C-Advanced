using System;
using System.Collections.Generic;
using System.Linq;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimension[0];
            var cols = dimension[1];
            var bloomSpots = new List<int[]>();
            var matrix = new int[rows, cols];
            FillMatrix(matrix);
            var command = Console.ReadLine();
            while (command != "Bloom Bloom Plow")
            {
                var coords = command.Split();
                var flowerRow = int.Parse(coords[0]);
                var flowerCol = int.Parse(coords[1]);
                if (flowerRow >= 0 && flowerRow < rows && flowerCol >= 0 && flowerCol < cols)
                {
                    matrix[flowerRow, flowerCol] = 1;
                    var currentSpot = new int[2] { flowerRow, flowerCol };
                    bloomSpots.Add(currentSpot);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                command = Console.ReadLine();
            }
            for (int f = 0; f < bloomSpots.Count; f++)
            {
                var row = bloomSpots[f][0];
                var col = bloomSpots[f][1];
                //up
                for (int i = row - 1; i >= 0; i--)
                {
                    matrix[i, col] += 1;
                }
                //down
                for (int i = row + 1; i < rows; i++)
                {
                    matrix[i, col] += 1;
                }
                //left
                for (int i = col - 1; i >= 0; i--)
                {
                    matrix[row, i] += 1;
                }
                //right
                for (int i = col + 1; i < cols; i++)
                {
                    matrix[row, i] += 1;
                }
            }
            PrintMatrix(matrix, rows, cols);

        }
        static int[,] FillMatrix(int[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}

