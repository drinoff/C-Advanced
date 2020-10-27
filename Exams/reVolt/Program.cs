
using System;
using System.IO;

namespace bee
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var commandCount = int.Parse(Console.ReadLine());
            var rows = fieldSize;
            var cols = fieldSize;
            var field = new char[rows, cols];

            var playerRow = 0;
            var playerCol = 0;
            for (int row = 0; row < rows; row++)
            {
                var currRow = Console.ReadLine();
                for (int col = 0; col < currRow.Length; col++)
                {
                    field[row, col] = currRow[col];
                    if (field[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            var edge = false;
            var finished = false;

            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        if (playerRow - 1 < 0)
                        {
                            field[playerRow, playerCol] = '-';
                            playerRow = field.GetLength(0) - 1;
                            edge = true;
                            field[playerRow, playerCol] = 'f';
                        }
                        if (edge)
                        {
                            edge = false;
                        }

                        else
                        {
                            field[playerRow, playerCol] = '-';
                            playerRow -= 1;
                        }

                        if (field[playerRow, playerCol] == 'F')
                        {
                            field[playerRow, playerCol] = 'f';
                            finished = true;
                            break;
                        }

                        else if (field[playerRow, playerCol] == 'B')
                        {
                            //field[playerRow, playerCol] = '-';
                            if (playerRow - 1 < 0)
                            {
                                
                                playerRow = field.GetLength(0) - 1;
                                edge = true;
                                field[playerRow, playerCol] = 'f';
                            }
                            playerRow -= 1;
                            if (field[playerRow, playerCol] == 'F')
                            {
                                field[playerRow, playerCol] = 'f';
                                finished = true;
                                break;
                            }
                            
                        }

                        else if (field[playerRow, playerCol] == 'T')
                        {
                            playerRow += 1;
                        }

                        else
                        {

                            field[playerRow, playerCol] = 'f';
                        }

                        break;
                    case "down":
                        if (playerRow + 1 > field.GetLength(0) - 1)
                        {
                            field[playerRow, playerCol] = '-';
                            playerRow = 0;
                            edge = true;
                        }
                        if (edge)
                        {
                            edge = false;
                        }

                        else
                        {
                            field[playerRow, playerCol] = '-';
                            playerRow += 1;
                        }

                        if (field[playerRow, playerCol] == 'F')
                        {
                            field[playerRow, playerCol] = 'f';
                            finished = true;
                            break;
                        }

                        else if (field[playerRow, playerCol] == 'B')
                        {
                            //field[playerRow, playerCol] = '-';
                            playerRow += 1;
                            if (field[playerRow, playerCol] == 'F')
                            {
                                field[playerRow, playerCol] = 'f';
                                finished = true;
                                break;
                            }
                        }

                        else if (field[playerRow, playerCol] == 'T')
                        {
                            playerRow -= 1;
                        }
                        else
                        {

                            field[playerRow, playerCol] = 'f';
                        }


                        break;
                    case "right":
                        if (playerCol + 1 > field.GetLength(1) - 1)
                        {
                            field[playerRow, playerCol] = '-';
                            playerCol = 0;
                            edge = true;
                        }
                        if (edge)
                        {
                            edge = false;
                        }

                        else
                        {
                            field[playerRow, playerCol] = '-';
                            playerCol += 1;
                        }

                        if (field[playerRow, playerCol] == 'F')
                        {
                            field[playerRow, playerCol] = 'f';
                            finished = true;
                            break;
                        }

                        else if (field[playerRow, playerCol] == 'B')
                        {
                            //field[playerRow, playerCol] = '-';
                            playerCol += 1;
                            if (field[playerRow, playerCol] == 'F')
                            {
                                field[playerRow, playerCol] = 'f';
                                finished = true;
                                break;
                            }
                        }

                        else if (field[playerRow, playerCol] == 'T')
                        {
                            playerCol -= 1;
                        }
                        else
                        {

                            field[playerRow, playerCol] = 'f';
                        }
                        break;
                    case "left":
                        if (playerCol - 1 < 0)
                        {
                            field[playerRow, playerCol] = '-';
                            playerRow = field.GetLength(1) - 1;
                            edge = true;
                        }
                        if (edge)
                        {
                        }

                        else
                        {
                            field[playerRow, playerCol] = '-';
                            playerCol -= 1;
                        }

                        if (field[playerRow, playerCol] == 'F')
                        {
                            field[playerRow, playerCol] = 'f';
                            finished = true;
                            break;
                        }

                        else if (field[playerRow, playerCol] == 'B')
                        {
                            //field[playerRow, playerCol] = '-';
                            if (playerCol - 1 < 0)
                            {
                                
                                playerCol = field.GetLength(1) - 1;
                                edge = true;
                            }
                            playerCol -= 1;
                            if (field[playerRow, playerCol] == 'F')
                            {
                                field[playerRow, playerCol] = 'f';
                                finished = true;
                                break;
                            }
                        }

                        else if (field[playerRow, playerCol] == 'T')
                        {
                            playerCol += 1;
                        }
                        else
                        {

                            field[playerRow, playerCol] = 'f';
                        }
                        break;
                }
                if (finished)
                {
                    break;
                }
            }
            if (finished)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
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
