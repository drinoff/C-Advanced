using System;
using System.Linq;

namespace diagonalDIff
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var rows = size;
            var cols = size;
            var matrix = new int[rows,cols];
            FillMatrix(matrix);
            Console.WriteLine(DiagonalDiff(matrix));

            

        }
        static int[] ParseInput()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        static int[,] FillMatrix(int[,] matrix)
        {
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = ParseInput();                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
                return matrix;
        }
        static int DiagonalDiff(int[,]matrix)
        {
            var PrimaryDiagonal = 0;
            var SecondaryDiagonal = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        PrimaryDiagonal += matrix[i, j];
                    }
                    if(i == matrix.GetLength(0)-j-1)
                    {
                        SecondaryDiagonal += matrix[i, j];
                    }
                }
               
            }
            return Math.Abs(PrimaryDiagonal - SecondaryDiagonal);
        }
    }
}
