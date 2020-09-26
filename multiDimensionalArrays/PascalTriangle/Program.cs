using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var jagged = new long[rows][];
            if (rows == 1) 
            {
                Console.WriteLine(1);
            }
            if (rows == 2)
            {
                Console.WriteLine(1);
                Console.WriteLine(1 + " " + 1);
            }
            if (rows >= 3)
            {
                jagged[0] = new long[1] { 1 };
                jagged[1] = new long[2] { 1, 1 };
                for (int row = 2; row < rows; row++)
                {
                    jagged[row] = new long[row + 1];
                    jagged[row][0] = 1;
                    for (int col = 1; col < row; col++)
                    {
                        jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
                    }
                    jagged[row][row] = 1;
                }

                for (int row = 0; row < rows; row++)
                {
                    Console.WriteLine($"{string.Join(" ", jagged[row])}" + " ");
                }
            }



        }
    }
}
