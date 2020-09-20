using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;

namespace snakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = size[0];
            var cols = size[1];
            var snakeString = Console.ReadLine();
            var stack = new Queue<char>(snakeString);
            var legacyStack = stack;
            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (stack.Count == 0)
                        {
                            for (int i = 0; i < snakeString.Length; i++)
                            {
                                stack.Enqueue(snakeString[i]);
                            }
                        }
                        matrix[row, col] = stack.Dequeue();
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (stack.Count == 0)
                        {
                            for (int i = 0; i < snakeString.Length; i++)
                            {
                                stack.Enqueue(snakeString[i]);
                            }
                        }
                        matrix[row, col] = stack.Dequeue();
                    }
                }
            }
            PrintMatrix(matrix, rows, cols);

        }
        static void PrintMatrix(char[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
