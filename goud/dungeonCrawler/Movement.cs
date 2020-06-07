using System;
using System.Linq;
using System.Numerics;
using dungeonCrawler.Enemy;

namespace dungeonCrawler
{
    public class Movement
    {
        private Player _player;
        private Grid _grid;
        private EnemyManager _enemyManager;

        public Movement(Player player, Grid grid, EnemyManager enemyManager)
        {
            _player = player;
            _grid = grid;
            _enemyManager = enemyManager;
        }

        public void Move(Direction dir)
        {
            Vector2d tempPos = new Vector2d(_player.x, _player.y);
            if (dir == Direction.up) tempPos.y -= 1;
            if (dir == Direction.down) tempPos.y += 1;
            if (dir == Direction.right) tempPos.x += 1;
            if (dir == Direction.left) tempPos.x -= 1;

            if (_grid.isWall(new Vector2d(tempPos.x, tempPos.y))) return;
            
            bool canMove = true;            
            switch (_grid.GetGrid()[tempPos.x, tempPos.y])
            {
                case 'M':
                    foreach (var enemyData in _enemyManager.getEnemies())
                    {
                        if (enemyData.X == tempPos.x && enemyData.Y == tempPos.y)
                        {
                            enemyData.Health -= 25;
                            if (enemyData.Health > 0)
                            {
                                canMove = false;
                            }
                        }
                    }

                    break;
            }

            // can move?
            if (canMove)
            {
                _player.Undraw();
                _grid.GetGrid()[_player.x, _player.y] = ' ';
                _player.x = tempPos.x;
                _player.y = tempPos.y;
                _grid.GetGrid()[_player.x, _player.y] = 'P';
                _player.Draw();
            }
        }
    }
}