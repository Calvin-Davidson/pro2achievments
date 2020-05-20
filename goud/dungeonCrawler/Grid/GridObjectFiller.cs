using System;

namespace dungeonCrawler
{
    public class GridObjectFiller
    {
        private int EnemyChange = 1;
        private int MoneyChange = 1;
        private int HealthChange = 1;

        public GridObjectFiller(char[,] grid)
        {
            for (var y = 0; y < grid.GetLength(1); y++)
            {
                for (var x = 0; x < grid.GetLength(0); x++)
                {
                    if (grid[x, y] == ' ')
                    {

                        Random r = new Random();
                        int A = r.Next(0, 100);
                        int B = r.Next(0, 100);
                        int C = r.Next(0, 100);

                        // Place enemy
                        if (A < EnemyChange)
                        {
                            grid[x, y] = 'M';
                        }

                        // Place money
                        else if (B < MoneyChange)
                        {
                            grid[x, y] = '$';
                        }

                        // Place health pickup
                        else if (C < HealthChange)
                        {
                            grid[x, y] = 'H';
                        }
                    }
                }
            }
        }
    }
}