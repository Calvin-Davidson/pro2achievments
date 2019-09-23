using System;
namespace dungeonCrawler
{
    static class monsters
    {
        static int playerMaxDamange = 100;
        static int monsterMaxDamage = 50;
        static int monsterMinDamage = 1;
        static int playerMinDamage = 10;
        static int monster1HP = 100;
        static int monster1X = 3;
        static int monster1Y = 3;

        static int monster2HP = 100;
        static int monster2X = 8;
        static int monster2Y = 1;

        static int monster3HP = 200;
        static int monster3X = 21;
        static int monster3Y = 8;
        public static void fight(int playerX, int PlayerY)
       {
           if (playerX == monster1X && PlayerY == monster1Y) {
               Console.Beep(1000, 300);
               var Random = new Random();
               var playerDamage = Random.Next(playerMinDamage, playerMaxDamange);

               var Random2 = new Random();
               var monsterDamage = Random.Next(monsterMinDamage, monsterMaxDamage);

               monster1HP -= playerDamage;
               Program.playerM.playerHP -= monsterDamage;

               if (Program.playerM.playerHP <= 0) {
                   Console.Clear();
                   Console.WriteLine("Sadly you are dead.");
               } 
               if (monster1HP <= 0) {
                   Program.grid.Replace(monster1X, monster1Y, ' ');
                   Console.Beep(100, 100);
                   Console.Beep(100, 100);
                   Console.Beep(100, 100);
               }
           } else if (playerX == monster2X && PlayerY == monster2Y) {
               Console.Beep(1000, 300);
               var Random = new Random();
               var playerDamage = Random.Next(playerMinDamage, playerMaxDamange);

               var Random2 = new Random();
               var monsterDamage = Random.Next(monsterMinDamage, monsterMaxDamage);

               monster2HP -= playerDamage;
               Program.playerM.playerHP -=  monsterDamage;

               if (Program.playerM.playerHP <= 0) {
                   Console.Clear();
                   Console.WriteLine("Sadly you are dead.");
               } 
               if (monster2HP <= 0) {
                   Program.grid.Replace(monster2X, monster2Y, ' ');
                   Console.Beep(100, 100);
                   Console.Beep(100, 100);
                   Console.Beep(100, 100);
               }
               } else if (playerX == monster3X && PlayerY == monster3Y) {
               Console.Beep(1000, 300);
               var Random = new Random();
               var playerDamage = Random.Next(playerMinDamage, playerMaxDamange+50);

               var Random2 = new Random();
               var monsterDamage = Random.Next(monsterMinDamage, monsterMaxDamage+50);

               monster3HP -= playerDamage;
               Program.playerM.playerHP -=  monsterDamage;

               if (Program.playerM.playerHP <= 0) {
                   Console.Clear();
                   Console.WriteLine("Sadly you are dead.");
               } 
               if (monster3HP <= 0) {
                   Program.grid.Replace(monster3X, monster3Y, ' ');
                   Console.Beep(100, 100);
                   Console.Beep(100, 100);
                   Console.Beep(100, 100);
               }
           } else {
               System.Threading.Thread.Sleep(5000);
           }
        }
    }
}