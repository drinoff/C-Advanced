using System;
using System.ComponentModel.Design;
using System.Data;

namespace matrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = ParseInput(" ");
            var rows = int.Parse(size[0]);
            var cols = int.Parse(size[1]);
            var matrix = new string[rows, cols];
            MatrixFiller(rows, cols, matrix);
            var input = Console.ReadLine();

            while (input != "END")
            {
                var command = input.Split();

                if (InvalidInputChecker(command, rows, cols))
                {

                }
                else
                {
                    matrix = SwapMatrixElements(matrix, command);

                    PrintMatrix(matrix, rows, cols);
                }

                input = Console.ReadLine();
            }
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
            return Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
        static bool InvalidInputChecker(string[] command, int rows, int cols)
        {
            if (command.Length == 5)
            {
                var row1 = int.Parse(command[1]);
                var col1 = int.Parse(command[2]);
                var row2 = int.Parse(command[3]);
                var col2 = int.Parse(command[4]);

                if (command[0] != "swap" || row1 < 0 || row1 >= rows || row2 < 0 || row2 >= rows || col1 < 0 || col1 >= cols || col2 < 0 || col2 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return true;
            }
        }
        static string[,] SwapMatrixElements(string[,] matrix, string[] command)
        {
            var row1 = int.Parse(command[1]);
            var col1 = int.Parse(command[2]);
            var row2 = int.Parse(command[3]);
            var col2 = int.Parse(command[4]);

            var swapper = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = swapper;
            return matrix;
        }
        static void PrintMatrix(string[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
