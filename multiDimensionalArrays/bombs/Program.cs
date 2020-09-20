using System;
using System.Linq;

namespace bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = ParseInput(" ");
            var rows = size[0];
            var cols = size[0];
            var matrix = new int[rows, cols];
            MatrixFiller(rows, cols, matrix);
            var bomsCoordinates = Console.ReadLine().Split();


            for (int i = 0; i < bomsCoordinates.Length; i++)
            {
                var currCoords = bomsCoordinates[i].Split(",");
                var row = int.Parse(currCoords[0]);
                var col = int.Parse(currCoords[1]);
                var bombPower = matrix[row, col];
                if (matrix[row, col] <= 0)
                {
                    continue;
                }
                else
                {
                    for (int j = row - 1; j <= row + 1; j++)
                    {
                        for (int k = col - 1; k <= col + 1; k++)
                        {
                            if (j < 0)
                            {
                                j = 0;
                            }
                            if (k < 0)
                            {
                                k = 0;
                            }
                            if (j >= matrix.GetLength(0))
                            {
                                continue;
                            }
                            if (k >= matrix.GetLength(1))
                            {
                                continue;
                            }
                            if (matrix[j, k] > 0)
                            {
                                matrix[j, k] -= bombPower;
                            }

                        }
                    }
                    matrix[row, col]= 0;
                }
            }
            //for (int i = 0; i < bomsCoordinates.Length; i++)
            //{
            //    var currCoords = bomsCoordinates[i].Split(",");
            //    var row = int.Parse(currCoords[0]);
            //    var col = int.Parse(currCoords[1]);
            //    matrix[row, col] = 0;
            //}
            var sumAlive = 0;
            var counter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(matrix[i,j]>0)
                    {
                        sumAlive += matrix[i, j];
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {counter}");
            Console.WriteLine($"Sum: {sumAlive}");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                    Console.Write(matrix[row, col] + " ");
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
