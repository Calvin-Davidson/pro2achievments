using System;
using System.Collections.Generic;

namespace dungeonCrawler.Enemy
{
    public class EnemyManager
    {
        private Char[,] grid;
        private List<EnemyData> enemies = new List<EnemyData>();

        public EnemyManager(Char[,] grid)
        {
            this.grid = grid;
        }

        public void loadEnemies()
        {
            for (var y = 0; y < grid.GetLength(1); y++)
            {
                for (var x = 0; x < grid.GetLength(0); x++)
                {
                    if (grid[x, y] == 'M')
                    {
                        enemies.Add(new EnemyData(x, y));
                    }
                }
            }
        }

        public List<EnemyData> getEnemies()
        {
            return this.enemies;
        }
    }
}