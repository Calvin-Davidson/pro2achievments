using System;
using System.Numerics;
using System.Collections.Generic;

namespace dungeonCrawler
{
    public class GridBuilder
    {
        private char[,] grid;

        public GridBuilder(char[,] grid)
        {
            this.grid = grid;

            // fills the grid with walls.
            for (var y = 0; y < grid.GetLength(1); y++)
            {
                for (var x = 0; x < grid.GetLength(0); x++)
                {
                    grid[x, y] = '#';
                }
            }

            // Removes walls to create the maze
            Generator();

            grid[1, 1] = 'P';
        }

        
        private Vector2d current = new Vector2d(1, 1);
        private List<Vector2d> steps = new List<Vector2d>();
        private void Generator()
        {
            var next = getOptions();
            if (next != null)
            {
                removeWalls(current, next);
                
                grid[next.x, next.y] = ' ';

                steps.Add(current);
                current = next;
                Generator();
            }
            else
            {
                if (steps.Count > 0)
                {
                    current = steps[steps.Count - 1];
                    steps.RemoveAt(steps.Count - 1);
                    Generator();
                }
            }
        }
        
        private Vector2d getOptions()
        {
            List<Vector2d> options = new List<Vector2d>();

            var up = new Vector2d(current.x, current.y - 2);
            var down = new Vector2d(current.x, current.y + 2);
            var left = new Vector2d(current.x - 2, current.y);
            var right = new Vector2d(current.x + 2, current.y);

            if (up.y > 0 && grid[up.x, up.y] == '#') options.Add(up);
            if (down.y < grid.GetLength(1) && grid[down.x, down.y] == '#') options.Add(down);
            if (left.x > 0 && grid[left.x, left.y] == '#') options.Add(left);
            if (right.x < grid.GetLength(0) -1 && grid[right.x, right.y] == '#') options.Add(right);

            if (options.Count == 0) return null;

            return options[new Random().Next(0, options.Count)];
        }
        
        private void removeWalls(Vector2d pos1, Vector2d pos2)
        {
            int X = (pos1.x + pos2.x) / 2;
            int Y = (pos1.y + pos2.y) / 2;
            grid[X, Y] = ' ';
        }
    }
}