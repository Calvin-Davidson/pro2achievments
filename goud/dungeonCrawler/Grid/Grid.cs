using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace dungeonCrawler
{
    public class Grid
    {
        private readonly char[,] grid = new char[Console.LargestWindowWidth / 3 - 1, Console.LargestWindowHeight / 3];


        public Grid()
        {
            new GridBuilder(grid);
            new GridObjectFiller(grid);
        }

        public char[,] GetGrid()
        {
            return this.grid;
        }


        public async void PaintGrid()
        {
            Console.Clear();
            StringBuilder str = new StringBuilder();

            for (var y = 0; y < grid.GetLength(1); y++)
            {
                for (var x = 0; x < grid.GetLength(0); x++)
                {
                    bool append = false;
                    switch (grid[x, y])
                    {
                        case 'P':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case '$':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 'H':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 'M':
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        default:
                            append = true;
                            str.Append(grid[x, y]);
                            break;
                    }

                    if (!append)
                    {
                        await Console.Out.WriteAsync(grid[x, y]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        await Console.Out.WriteAsync(str);
                        str.Clear();
                    }
                }

                Console.Out.WriteLineAsync();
            }
        }
    }
}