using System;
using System.Linq;

namespace maximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = ParseInput(" ");
            var rows = size[0];
            var cols = size[1];
            var matrix = new int[rows, cols];
            MatrixFiller(rows, cols, matrix);
            var maxSum = int.MinValue;
            var currentSum = 0;
            var primaryRowIndex = 0;
            var primarColIndex = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        primaryRowIndex = row;
                        primarColIndex = col;
                    }
                    currentSum = 0;
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = primaryRowIndex; i < primaryRowIndex + 3; i++)
            {
                for (int j = primarColIndex; j < primarColIndex + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
        static int[,] MatrixFiller(int rows, int cols, int[,] matrix)
        {

            for (int row = 0; row < rows; row++)
            {
                var currentRow = ParseInput(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            return matrix;
        }
        static int[] ParseInput(string separator)
        {
            return Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

    }
}
