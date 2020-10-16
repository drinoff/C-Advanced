
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

            var beeRow = 0;
            var beeCol = 0;
            for (int row = 0; row < rows; row++)
            {
                var currRow = Console.ReadLine();
                for (int col = 0; col < currRow.Length; col++)
                {
                    field[row, col] = currRow[col];
                    if (field[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
            var command = Console.ReadLine();
            var polinatedFlowers = 0;
            var gotLost = false;
            while (command != "End")
            {
                switch (command)
                {
                    case "up":
                        if (beeRow - 1 < 0)
                        {
                            Console.WriteLine($"The bee got lost!");
                            gotLost = true;
                            field[beeRow, beeCol] = '.';
                            break;
                        }
                        else
                        {
                            field[beeRow, beeCol] = '.';
                            beeRow -= 1;
                            if (field[beeRow, beeCol] == 'f')
                            {
                                polinatedFlowers++;
                                field[beeRow, beeCol] = 'B';
                            }
                            else if (field[beeRow, beeCol] == 'O')
                            {
                                field[beeRow, beeCol] = '.';
                                beeRow -= 1;
                                if (field[beeRow, beeCol] == 'f')
                                {
                                    polinatedFlowers++;
                                    field[beeRow, beeCol] = 'B';
                                }
                                field[beeRow, beeCol] = 'B';
                            }
                            field[beeRow, beeCol] = 'B';
                        }
                        break;
                    case "down":
                        if (beeRow + 1 > field.GetLength(0)-1)
                        {
                            Console.WriteLine($"The bee got lost!");
                            field[beeRow, beeCol] = '.';
                            gotLost = true;
                            break;
                        }
                        else
                        {
                            field[beeRow, beeCol] = '.';
                            beeRow += 1;
                            if (field[beeRow, beeCol] == 'f')
                            {
                                polinatedFlowers++;
                                field[beeRow, beeCol] = 'B';
                            }
                            else if (field[beeRow, beeCol] == 'O')
                            {
                                field[beeRow, beeCol] = '.';
                                beeRow += 1;
                                if (field[beeRow, beeCol] == 'f')
                                {
                                    polinatedFlowers++;
                                    field[beeRow, beeCol] = 'B';
                                }
                                field[beeRow, beeCol] = 'B';
                            }
                            field[beeRow, beeCol] = 'B';
                        }

                        break;
                    case "right":
                        if (beeCol + 1 > field.GetLength(1)-1)
                        {
                            Console.WriteLine($"The bee got lost!");
                            field[beeRow, beeCol] = '.';
                            gotLost = true;
                            break;
                        }

                        else
                        {
                            field[beeRow, beeCol] = '.';
                            beeCol += 1;
                            if (field[beeRow, beeCol] == 'f')
                            {
                                polinatedFlowers++;
                                field[beeRow, beeCol] = 'B';
                            }
                            else if (field[beeRow, beeCol] == 'O')
                            {
                                field[beeRow, beeCol] = '.';
                                beeCol += 1;
                                if (field[beeRow, beeCol] == 'f')
                                {
                                    polinatedFlowers++;
                                    field[beeRow, beeCol] = 'B';
                                }
                                field[beeRow, beeCol] = 'B';
                            }
                            field[beeRow, beeCol] = 'B';
                        }

                        break;
                    case "left":
                        if (beeCol - 1 < 0)
                        {
                            Console.WriteLine($"The bee got lost!");
                            field[beeRow, beeCol] = '.';
                            gotLost = true;
                            break;
                        }

                        else
                        {
                            field[beeRow, beeCol] = '.';
                            beeCol -= 1;
                            if (field[beeRow, beeCol] == 'f')
                            {
                                polinatedFlowers++;
                                field[beeRow, beeCol] = 'B';
                            }
                            else if (field[beeRow, beeCol] == 'O')
                            {
                                field[beeRow, beeCol] = '.';
                                beeCol -= 1;
                                if (field[beeRow, beeCol] == 'f')
                                {
                                    polinatedFlowers++;
                                    field[beeRow, beeCol] = 'B';
                                }
                                field[beeRow, beeCol] = 'B';
                            }
                            field[beeRow, beeCol] = 'B';
                        }
                        break;
                }

                if(gotLost)
                {
                    break;
                }
                command = Console.ReadLine();
                
            }

            if (polinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinatedFlowers} flowers!");
            }

            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinatedFlowers} flowers more");
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
