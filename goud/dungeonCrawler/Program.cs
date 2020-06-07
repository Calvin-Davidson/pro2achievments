using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;
using dungeonCrawler.Enemy;
using Microsoft.VisualBasic;

namespace dungeonCrawler
{
    class Program
    {
        private Grid grid;
        private Player player;
        private Movement movement;
        private EnemyManager _enemyManager;
        private List<Monster> monsters = new List<Monster>();
        private bool finished = false;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(Console.LargestWindowWidth / 2 + 10, Console.LargestWindowHeight / 2 + 10);
            Console.Clear();

            Program program = new Program();
            program.grid = new Grid();
            program.player = new Player();
            program._enemyManager = new EnemyManager(program.grid.GetGrid());
            program._enemyManager.loadEnemies();
            program.movement = new Movement(program.player, program.grid, program._enemyManager);

            Console.WriteLine("Welkom to dungeon crawler\nPress space to continue");

            Console.ReadKey();

            program.start();
        }

        public void finish()
        {
            finished = true;
        }

        private void start()
        {
            grid.PaintGrid();
            Input();
        }

        private void Input()
        {
            while (finished == false)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key.ToString())
                {
                    case "W":
                        movement.Move(Direction.up);
                        break;
                    case "A":
                        movement.Move(Direction.left);
                        break;
                    case "S":
                        movement.Move(Direction.down);
                        break;
                    case "D":
                        movement.Move(Direction.right);
                        break;
                }
            }
        }
    }
}