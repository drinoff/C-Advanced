using System;
using System.Linq;

namespace squareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = ParseInput(", ");
            var rows = size[0];
            var cols = size[1];
            var matrix = new int[rows, cols];
            MatrixFiller(rows, cols, matrix);
            var maxSquareSum = int.MinValue;
            var coords = new int[2];
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    var squareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if(squareSum>maxSquareSum)
                    {
                        maxSquareSum = squareSum;
                        coords[0] = row;
                        coords[1] = col;
                        squareSum = 0;
                    }
                }
            }
            Console.Write(matrix[coords[0], coords[1]] + " ");
            Console.Write(matrix[coords[0], coords[1]+1] + " ");
            Console.WriteLine();
            Console.Write(matrix[coords[0]+1, coords[1]] + " ");
            Console.Write(matrix[coords[0]+1, coords[1]+1] + " ");
            Console.WriteLine();
            Console.WriteLine(maxSquareSum);
        }
        static int[,] MatrixFiller(int rows, int cols, int[,] matrix)
        {

            for (int row = 0; row < rows; row++)
            {
                var currentRow = ParseInput(", ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            return matrix;
        }
        static int[] ParseInput(string separator)
        {
            return Console.ReadLine().Split(separator).Select(int.Parse).ToArray();
        }
    }
}
