using System;
namespace dungeonCrawler
{

    class PlayerWalk
    {   
        public static void move(string direction) {
            Char VooruitChar = Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY-1);
            Char AchteruitChar = Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY+1);
            Char RechtsChar = Program.grid.GetFrom(Program.playerM.playerX+1, Program.playerM.playerY);
            Char LinksChar = Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY);
            switch(direction.ToString()) {
                case "Vooruit":
               if (VooruitChar == 'W') {
                  win();
               } else if (VooruitChar == 'M') {
                   monsters.fight(Program.playerM.playerX, Program.playerM.playerY-1);
                    Console.Clear();
                    loader.loadMap(Program.gameM.theMap);
                    loader.loadHP();
               } else if (VooruitChar == '$') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY-1, 'P');
            Program.playerM.playerY--;
            Program.playerM.playercoins += 5;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               } else if (VooruitChar == '#') {
                   return;
               } else if (VooruitChar == 'H') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY-1, 'P');
            Program.playerM.playerHP = Program.playerM.playerHP + 50;
            Program.playerM.playerY--;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();                   
               } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY-1, 'P');
            Program.playerM.playerY--;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
            }
               break;
                case "Achteruit":
                if (AchteruitChar == 'W') {
                   win();
               } else if (AchteruitChar == 'M') {
                    monsters.fight(Program.playerM.playerX, Program.playerM.playerY+1);
                    Console.Clear();
                    loader.loadMap(Program.gameM.theMap);
                    loader.loadHP();
               } else if (AchteruitChar == '$') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY+1, 'P');
            Program.playerM.playerY++;
            Program.playerM.playercoins += 5;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               } else if (AchteruitChar == '#') {
                   return;
            } else if (AchteruitChar == 'H') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY+1, 'P');
            Program.playerM.playerHP = Program.playerM.playerHP + 50;
            Program.playerM.playerY++;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY+1, 'P');
            Program.playerM.playerY++;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               }
                break;
                case "Rechts":
                if (RechtsChar == 'W') {
                   win();
               } else if (RechtsChar == 'M') {
                    monsters.fight(Program.playerM.playerX+1, Program.playerM.playerY);
                    Console.Clear();
                    loader.loadMap(Program.gameM.theMap);
                    loader.loadHP();
                    
               } else if (RechtsChar == '$') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, 'P');
            Program.playerM.playerX++;
            Program.playerM.playercoins += 5;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               } else if (RechtsChar == '#') {
                   return;
                } else if (RechtsChar == 'H') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, 'P');
            Program.playerM.playerHP = Program.playerM.playerHP + 50;
            Program.playerM.playerX++;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, 'P');
            Program.playerM.playerX++;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               }
                break;
                case "Links":
                if (LinksChar == 'W') {
                   win();
               } else if (LinksChar == 'M') {
                    monsters.fight(Program.playerM.playerX-1, Program.playerM.playerY-1);
                    Console.Clear();
                    loader.loadMap(Program.gameM.theMap);
                    loader.loadHP();
               } else if (LinksChar == '$') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX-1, Program.playerM.playerY, 'P');
            Program.playerM.playerX--;
            Program.playerM.playercoins += 5;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
            } else if (LinksChar == '#') {
                   return;
            } else if (LinksChar == 'H') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX-1, Program.playerM.playerY, 'P');
            Program.playerM.playerHP = Program.playerM.playerHP + 50;
            Program.playerM.playerX--;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX-1, Program.playerM.playerY, 'P');
            Program.playerM.playerX--;
            Console.Clear();
            loader.loadMap(Program.gameM.theMap);
            loader.loadHP();
               }
                break;
            }
        }
                public static void win() {
                    Console.Clear();
                    Program.gameM.haswon = true;
         }
    }
}
