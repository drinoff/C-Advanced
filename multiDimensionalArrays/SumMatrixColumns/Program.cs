using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace sumMatrixElemenets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ParseInput(',');
            var rows = input[0];
            var cols = input[1];

            var matrix = new int[rows, cols];
            
            for (int row = 0; row < rows; row++)
            {
                var currentRow = ParseInput(' ');
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            SumMatrixCols(matrix);
            
        }
        static int[] ParseInput(params char[] separator)
        {
            return Console.ReadLine().Split(separator).Select(int.Parse).ToArray();
        }
        static void SumMatrixCols(int[,] matrix)
        {
            var sumMatrixCols = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumMatrixCols += matrix[row, col];
                }
                Console.WriteLine(sumMatrixCols);
                sumMatrixCols = 0;
            }

            
        }
    }
}

