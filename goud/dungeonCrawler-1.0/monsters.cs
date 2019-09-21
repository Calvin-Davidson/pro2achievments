using System;
namespace dungeonCrawler
{
    static class monsters
    {
        static int monster1HP = 100;
        static int monster1X = 3;
        static int monster1Y = 3;

        static int monster2HP = 100;
        static int monster2X;
        static int monster2Y;

        static int monster3HP = 100;
        static int monster3X;
        static int monster3Y;
        public static void fight(int playerX, int PlayerY)
       {
           if (playerX == monster1X && PlayerY == monster1Y) {
               Console.Beep(1000, 300);
               var Random = new Random();
               var playerDamage = Random.Next(0, 100);

               var Random2 = new Random();
               var monsterDamage = Random.Next(0, 100);

               monster1HP -= playerDamage;
               Program.playerM.playerHP -=  monsterDamage;

               if (Program.playerM.playerHP <= 0) {
                   Console.Clear();
                   Console.WriteLine("Sadly you are dead.");
               } 
               if (monster1HP <= 0) {
                   Program.grid.Replace(monster1X, monster1Y, ' ');
               }
           } else if (playerX == monster2X && PlayerY == monster2Y) {
               Console.Beep(1000, 300);
               var Random = new Random();
               var playerDamage = Random.Next(0, 100);

               var Random2 = new Random();
               var monsterDamage = Random.Next(0, 100);

               monster2HP -= playerDamage;
               Program.playerM.playerHP -=  monsterDamage;

               if (Program.playerM.playerHP <= 0) {
                   Console.Clear();
                   Console.WriteLine("Sadly you are dead.");
               } 
               if (monster3HP <= 0) {
                   Program.grid.Replace(monster2X, monster2Y, ' ');
               }
               } else if (playerX == monster3X && PlayerY == monster3Y) {
               Console.Beep(1000, 300);
               var Random = new Random();
               var playerDamage = Random.Next(0, 100);

               var Random2 = new Random();
               var monsterDamage = Random.Next(0, 100);

               monster3HP -= playerDamage;
               Program.playerM.playerHP -=  monsterDamage;

               if (Program.playerM.playerHP <= 0) {
                   Console.Clear();
                   Console.WriteLine("Sadly you are dead.");
               } 
               if (monster3HP <= 0) {
                   Program.grid.Replace(monster3X, monster3Y, ' ');
               }
           } else {
               
           }
        }
    }
}