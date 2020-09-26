using System;
using System.Linq;

namespace miner
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = ParseInput(" ").Select(int.Parse).ToArray();
            var rows = size[0];
            var cols = size[0];
            var movement = ParseInput(" ");

            var matrix = new string[rows, cols];
            MatrixFiller(rows, cols, matrix);
            var minnerRow = 0;
            var minnerCol = 0;
            var totalCoal = 0;

            for (int i = 0; i < movement.Length; i++)
            {
                var currentMove = movement[i];
                if (CheckCoal(matrix, rows, cols))
                {
                    MinnerPosition(matrix, minnerRow, minnerCol, rows, cols);
                    Move(matrix, currentMove,minnerRow,minnerCol,totalCoal);
                }
                else
                {
                    MinnerPosition(matrix, minnerRow, minnerCol, rows, cols);
                    Console.WriteLine($"You collected all coals! ({minnerRow}, {minnerCol})");
                }
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
        static string[,] Move(string[,] matrix, string currentMove,int minnerRow, int minnerCol,int totalCoal)
        {
            switch (currentMove)
            {                
                case "up":
                    if(matrix[minnerRow,minnerCol+1] == "e")
                    {
                        Console.WriteLine($"Game over! ({minnerRow}, {minnerCol-1})");
                        System.Environment.Exit(0);
                    }
                    else if(matrix[minnerRow, minnerCol - 1] == "c")
                    {
                        totalCoal++;
                        matrix[minnerRow, minnerCol - 1] = "s";
                        matrix[minnerRow, minnerCol] = "*";
                    }
                    minnerCol--;
                    break;
                case "down":
                    if (matrix[minnerRow, minnerCol + 1] == "e")
                    {
                        Console.WriteLine($"Game over! ({minnerRow}, {minnerCol - 1})");
                        System.Environment.Exit(0);
                    }
                    else if (matrix[minnerRow, minnerCol + 1] == "c")
                    {
                        totalCoal++;
                    }
                    minnerCol++;
                    break;
                case "left":
                    if (matrix[minnerRow-1, minnerCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({minnerRow}, {minnerCol - 1})");
                        System.Environment.Exit(0);
                    }
                    else if (matrix[minnerRow-1, minnerCol] == "c")
                    {
                        totalCoal++;
                    }
                    minnerRow--;
                    break;
                case "right":
                    break;
            }
        }
        static bool CheckCoal(string[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == "c")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void MinnerPosition(string[,] matrix, int minnerRow, int minnerCol,int rows,int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(matrix[row,col] == "s")
                    {
                        minnerRow = row;
                        minnerCol = col;
                    }
                }
            }
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
