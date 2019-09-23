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
                   Console.Clear();
                   Console.WriteLine("You win");
                return;
               } else if (VooruitChar == 'M') {
                   
               } else if (VooruitChar == '$') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY-1, 'P');
            Program.playerM.playerY--;
            Program.playerM.playercoins += 5;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
               } else if (VooruitChar == '#') {
                   return;
               } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY-1, 'P');
            Program.playerM.playerY--;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
            }
               break;
                case "Achteruit":
                               if (AchteruitChar == 'W') {

               } else if (AchteruitChar == 'M') {
                   
               } else if (AchteruitChar == '$') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY+1, 'P');
            Program.playerM.playerY++;
            Program.playerM.playercoins += 5;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
               } else if (AchteruitChar == '#') {
                   return;
               } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY+1, 'P');
            Program.playerM.playerY++;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
               }
                break;
                case "Rechts":
                               if (RechtsChar == 'W') {

               } else if (RechtsChar == 'M') {
                   
               } else if (RechtsChar == '$') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, 'P');
            Program.playerM.playerX++;
            Program.playerM.playercoins += 5;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
               } else if (RechtsChar == '#') {
                   return;
               } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, 'P');
            Program.playerM.playerX++;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
               }
                break;
                case "Links":
                if (LinksChar == 'W') {

               } else if (LinksChar == 'M') {
                   
               } else if (LinksChar == '$') {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX-1, Program.playerM.playerY, 'P');
            Program.playerM.playerX--;
            Program.playerM.playercoins += 5;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
               } else if (LinksChar == '#') {
                   return;
               } else {
            Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
            Program.grid.Replace(Program.playerM.playerX-1, Program.playerM.playerY, 'P');
            Program.playerM.playerX--;
            Console.Clear();
            loader.loadMap();
            loader.loadHP();
               }
                break;
            }
        }
    }
}
