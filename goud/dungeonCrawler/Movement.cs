using System;
using System.Numerics;

namespace dungeonCrawler
{
    public class Movement
    {
        private Player _player;
        private Grid _grid;

        public Movement(Player player, Grid grid)
        {
            _player = player;
            _grid = grid;
        }

        public void Move(Direction dir)
        {
            Vector2 tempPos = new Vector2(_player.x, _player.y);
            if (dir == Direction.up) tempPos.Y -= 1;
            if (dir == Direction.down) tempPos.Y += 1;
            if (dir == Direction.right) tempPos.X += 1;
            if (dir == Direction.left) tempPos.X -= 1;

            // can move?
            if (_grid.getGrid()[(int) tempPos.X, (int) tempPos.Y] != '#')
            {
                _grid.getGrid()[_player.x, _player.y] = ' ';
                
                _player.x = (int) tempPos.X;
                _player.y = (int) tempPos.Y;

                _grid.getGrid()[_player.x, _player.y] = 'P';

                Console.Clear();
                _grid.PaintGrid();
            }
        }
    }
}