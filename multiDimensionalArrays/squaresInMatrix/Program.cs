using System;
using System.Data;
using System.Linq;

namespace squaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = ParseInput(" ").Select(int.Parse).ToArray();
            var rows = size[0];
            var cols = size[1];
            var matrix = new string[rows, cols];
            MatrixFiller(rows, cols, matrix);
            Console.WriteLine(MatrixSquaresChecker(matrix));
        }
        static string[,] MatrixFiller(int rows, int cols, string[,] matrix)
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
        static string[] ParseInput(string separator)
        {
            return Console.ReadLine().Split(separator).ToArray();
        }
        static int MatrixSquaresChecker(string[,] matrix)
        {
            var counter = 0;
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
