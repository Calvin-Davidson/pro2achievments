using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace dungeonCrawler
{
    public class Grid
    {
        private char[,] grid = new char[Console.LargestWindowWidth / 3 - 1, Console.LargestWindowHeight / 3];


        public Grid()
        {
            new GridBuilder(grid);
            new GridObjectFiller(grid);
        }

        public char[,] getGrid()
        {
            return this.grid;
        }


        public void PaintGrid()
        {
            for (var y = 0; y < grid.GetLength(1); y++)
            {
                for (var x = 0; x < grid.GetLength(0); x++)
                {
                    switch (grid[x, y])
                    {
                        case 'P':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case '$':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 'H':
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 'M':
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }

                    Console.Write(grid[x, y]);
                }

                Console.WriteLine();
            }
        }
    }
}