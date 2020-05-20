﻿using System;
using System.Collections.Generic;
using System.Timers;

namespace dungeonCrawler
{
    class Program
    {
        private Grid grid;
        private Player player;
        private Movement movement;
        private List<Monster> monsters = new List<Monster>();
        private bool finished = false;

        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth / 2 + 10, Console.LargestWindowHeight / 2 + 10);
            Console.Clear();

            Program program = new Program();
            program.grid = new Grid();
            program.player = new Player();
            program.movement = new Movement(program.player, program.grid);

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
            Console.Clear();

            grid.PaintGrid();
            Input();
        }

        private void Input()
        {
            while (finished == false)
            {
                ConsoleKey key = Console.ReadKey().Key;
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