using System;
using System.Linq;

namespace primaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var rows = size;
            var cols = size;
            var matrix = new int[rows, cols];
            matrix = MatrixFiller(rows, cols, matrix);
            Console.WriteLine(SumPrimaryDiagonal(matrix));
        }
        static int[,] MatrixFiller(int rows, int cols, int[,] matrix)
        {

            for (int row = 0; row < rows; row++)
            {
                var currentRow = ParseInput(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            return matrix;
        }
        static int[] ParseInput(params char[] separator)
        {
            return Console.ReadLine().Split(separator).Select(int.Parse).ToArray();
        }
        static int SumPrimaryDiagonal(int[,]matrix)
        {
            var sumPrimaryDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(row == col)
                    {
                        sumPrimaryDiagonal += matrix[row, col];
                    }
                }
            }
            return sumPrimaryDiagonal;
        }
    }
}
