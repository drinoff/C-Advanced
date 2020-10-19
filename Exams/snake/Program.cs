
using System;
using System.IO;

namespace bee
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var rows = fieldSize;
            var cols = fieldSize;
            var field = new char[rows, cols];

            var snakeRow = 0;
            var snakeCol = 0;
            for (int row = 0; row < rows; row++)
            {
                var currRow = Console.ReadLine();
                for (int col = 0; col < currRow.Length; col++)
                {
                    field[row, col] = currRow[col];
                    if (field[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }
            var command = Console.ReadLine();
            var foodEaten = 0;
            var gotLost = false;
            while (command != "End")
            {
                switch (command)
                {
                    case "up":
                        if (snakeRow - 1 < 0)
                        {
                            Console.WriteLine($"Game over!");
                            gotLost = true;
                            field[snakeRow, snakeCol] = '.';
                            break;
                        }
                        else
                        {
                            field[snakeRow, snakeCol] = '.';
                            snakeRow -= 1;
                            if (field[snakeRow, snakeCol] == '*')
                            {
                                foodEaten++;
                                field[snakeRow, snakeCol] = 'S';
                                if (foodEaten >= 10)
                                {
                                    break;
                                }
                            }
                            else if (field[snakeRow, snakeCol] == 'B')
                            {
                                field[snakeRow, snakeCol] = '.';
                                for (int row = 0; row < rows; row++)
                                {
                                    for (int col = 0; col < cols; col++)
                                    {
                                        if (field[row, col] == 'B')
                                        {
                                            snakeRow = row;
                                            snakeCol = col;
                                        }
                                    }
                                }
                            }
                            field[snakeRow, snakeCol] = 'S';
                        }
                        break;
                    case "down":
                        if (snakeRow + 1 > field.GetLength(0) - 1)
                        {
                            Console.WriteLine($"Game over!");
                            field[snakeRow, snakeCol] = '.';
                            gotLost = true;
                            break;
                        }
                        else
                        {
                            field[snakeRow, snakeCol] = '.';
                            snakeRow += 1;
                            if (field[snakeRow, snakeCol] == '*')
                            {
                                foodEaten++;
                                field[snakeRow, snakeCol] = 'S';
                                if (foodEaten >= 10)
                                {
                                    break;
                                }
                            }
                            else if (field[snakeRow, snakeCol] == 'B')
                            {
                                field[snakeRow, snakeCol] = '.';
                                for (int row = 0; row < rows; row++)
                                {
                                    for (int col = 0; col < cols; col++)
                                    {
                                        if (field[row, col] == 'B' && field[row, col] != field[snakeRow, snakeCol])
                                        {
                                            snakeRow = row;
                                            snakeCol = col;
                                        }
                                    }
                                }
                            }
                            field[snakeRow, snakeCol] = 'S';
                        }

                        break;
                    case "right":
                        if (snakeCol + 1 > field.GetLength(1) - 1)
                        {
                            Console.WriteLine($"Game over!");
                            field[snakeRow, snakeCol] = '.';
                            gotLost = true;
                            break;
                        }

                        else
                        {
                            field[snakeRow, snakeCol] = '.';
                            snakeCol += 1;
                            if (field[snakeRow, snakeCol] == '*')
                            {
                                foodEaten++;
                                field[snakeRow, snakeCol] = 'S';
                                if (foodEaten >= 10)
                                {
                                    break;
                                }
                            }
                            else if (field[snakeRow, snakeCol] == 'B')
                            {
                                field[snakeRow, snakeCol] = '.';
                                for (int row = 0; row < rows; row++)
                                {
                                    for (int col = 0; col < cols; col++)
                                    {
                                        if (field[row, col] == 'B' && field[row, col] != field[snakeRow, snakeCol])
                                        {
                                            snakeRow = row;
                                            snakeCol = col;
                                        }
                                    }
                                }
                            }
                            field[snakeRow, snakeCol] = 'S';
                        }

                        break;
                    case "left":
                        if (snakeCol - 1 < 0)
                        {
                            Console.WriteLine($"Game over!");
                            field[snakeRow, snakeCol] = '.';
                            gotLost = true;
                            break;
                        }

                        else
                        {
                            field[snakeRow, snakeCol] = '.';
                            snakeCol -= 1;
                            if (field[snakeRow, snakeCol] == '*')
                            {
                                foodEaten++;
                                field[snakeRow, snakeCol] = 'S';
                                if (foodEaten >= 10)
                                {
                                    break;
                                }
                            }
                            else if (field[snakeRow, snakeCol] == 'B')
                            {
                                field[snakeRow, snakeCol] = '.';
                                for (int row = 0; row < rows; row++)
                                {
                                    for (int col = 0; col < cols; col++)
                                    {
                                        if (field[row, col] == 'B' && field[row, col] != field[snakeRow, snakeCol])
                                        {
                                            snakeRow = row;
                                            snakeCol = col;
                                        }
                                    }
                                }
                            }
                            field[snakeRow, snakeCol] = 'S';
                        }
                        break;
                }

                if (gotLost)
                {
                    break;
                }
                if (foodEaten >= 10)
                {
                    break;
                }
                command = Console.ReadLine();

            }

            if (foodEaten >= 10)
            {
                Console.WriteLine($"You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {foodEaten}");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
