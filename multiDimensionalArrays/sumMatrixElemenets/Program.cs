using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace sumMatrixElemenets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ParseInput();
            var rows = input[0];
            var cols = input[1];

            var matrix = new int[rows, cols];
            long matrixElSum = 0;
            for (int row = 0; row < rows; row++)
            {
                var currentRow = ParseInput();
                matrixElSum += currentRow.Sum();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(matrixElSum);
        }
        static int[] ParseInput()
        {
            return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        }
    }
}
