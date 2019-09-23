﻿using System;
namespace dungeonCrawler
{

    class PlayerWalk
    {   
        public static void vooruit()
        {
            Console.WriteLine(Program.playerM.playerX);
        if (Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY-1).Equals('#')) {
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            return;
        } else if (Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY).Equals('$')) { 
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY-1, 'P');
            Program.playerM.playercoins = Program.playerM.playercoins + 5;
        } else if (Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY).Equals('W')) { 
        Console.Clear();
        Program.gameM.Started = false;
        Console.WriteLine("You win");
        } else if (Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY).Equals('M')) {
             monsters.fight(Program.playerM.playerX-1, Program.playerM.playerY);
             loader.loadMap();
             loader.loadHP();
        } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY-1, 'P');
            Program.playerM.playerY--;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            }
        }
        public static void achteruit()
        {
            Console.WriteLine(Program.playerM.playerX);
        if (Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY+1).Equals('#')) {
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            return;
        } else if (Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY).Equals('$')) { 
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY+1, 'P');
            Program.playerM.playercoins = Program.playerM.playercoins + 5;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
        } else if (Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY).Equals('W')) { 
            Console.Clear();
            Program.gameM.Started = false;
            Console.WriteLine("You win");
        } else if (Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY+1).Equals('M')) {
             monsters.fight(Program.playerM.playerX, Program.playerM.playerY+1);
             loader.loadMap();
             loader.loadHP();    
        } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY+1, 'P');
            Program.playerM.playerY++;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            }
        }
        public static void rechts()
        {
            Console.WriteLine(Program.playerM.playerX);
        if (Program.grid.GetFrom(Program.playerM.playerX+1, Program.playerM.playerY).Equals('#')) {
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            return;
        } else if (Program.grid.GetFrom(Program.playerM.playerX+1, Program.playerM.playerY).Equals('$')) { 
            Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, 'P');
            Program.playerM.playercoins = Program.playerM.playercoins + 5;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
       } else if (Program.grid.GetFrom(Program.playerM.playerX+1, Program.playerM.playerY).Equals('W')) { 
            Console.Clear();
            Program.gameM.Started = false;
            Console.WriteLine("You win");
        } else if (Program.grid.GetFrom(Program.playerM.playerX+1, Program.playerM.playerY).Equals('M')) {
             monsters.fight(Program.playerM.playerX+1, Program.playerM.playerY);
             loader.loadMap();
             loader.loadHP();
        } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, 'P');
            Program.playerM.playerX++;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            }
        }
        public static void links()
        {
            Console.WriteLine(Program.playerM.playerX);
        if (Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY).Equals('#')) {
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            return;
        } else if (Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY).Equals('$')) {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX-1, Program.playerM.playerY, 'p');
            Program.playerM.playercoins = Program.playerM.playercoins + 5;
        } else if (Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY).Equals('W')) {
            Console.Clear();
            Program.gameM.Started = false;
            Console.WriteLine("You win");
        } else if (Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY).Equals('M')) {
             monsters.fight(Program.playerM.playerX-1, Program.playerM.playerY);
             loader.loadMap();
             loader.loadHP();
        } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX-1, Program.playerM.playerY, 'P');
            Program.playerM.playerX--;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            }
        }
    }
}