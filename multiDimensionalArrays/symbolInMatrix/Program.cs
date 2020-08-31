using System;
using System.Data.Common;
using System.Linq;

namespace symbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var rows = size;
            var cols = size;
            var matrix = new char[rows, cols];
            MatrixFiller(rows, cols, matrix);
            var symbol = char.Parse(Console.ReadLine());
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        System.Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix ");
            
        }
        static char[,] MatrixFiller(int rows, int cols, char[,] matrix)
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
        static char[] ParseInput(params char[] separator)
        {
            return Console.ReadLine().ToCharArray();
        }
    }
}
