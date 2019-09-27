using System;
namespace dungeonCrawler
{
    static class monsters
    {
            private static int PlayerMaxDamage = 75;
            private static int PlayerMinDamage = 25;
            private static int MonsterMaxDamage = 25;
            private static int MonsterMinDamage = 5;


            public static int[,] MonstersArray = {
            //MonsterID - MonsterHP - LocationY - LocationX
              {1,100,0,0},
              {2,100,0,0},
              {3,100,0,0},
              {4,100,0,0},
              {5,100,0,0},
              {6,100,0,0},
              {7,100,0,0},
              {8,100,0,0},
              {9,100,0,0},
              {10,100,0,0}
              };
              
        public static void fight(int playerX, int PlayerY) {
            for(int y = 0; y < MonstersArray.GetLength(0); y++)
            {
                if(PlayerY == MonstersArray[y, 2] && playerX == MonstersArray[y, 3]) {
                    Console.Beep(200, 350);
                    Random random = new Random();
                    Random random2 = new Random();

                    int PlayerDamage = random.Next(PlayerMinDamage, PlayerMaxDamage);
                    int MonsterDamage = random2.Next(MonsterMinDamage, MonsterMaxDamage);

                    MonstersArray[y, 1] -= PlayerDamage;
                    Program.playerM.playerHP -= MonsterDamage;

                    if (MonstersArray[y, 1] <= 0) {
                        Program.grid.Replace(MonstersArray[y, 3], MonstersArray[y,2], ' ');
                        Console.Beep(600, 300);

                        Console.Clear();
                        loader.loadMap();
                        loader.loadHP();
                    } else {
                        Console.Clear();
                        loader.loadMap();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your HP: " + Program.playerM.playerHP);
                        Console.WriteLine("MonsterHP: " + MonstersArray[y, 1]);
                        Console.ResetColor();
                    }
                    break;

                }
            }
        }
        public static void LoadMonsterArray() {
                for(int y = 0; y < Program.grid.Get2DArray().GetLength(0); y++)
            {
                for(int x = 0; x < Program.grid.Get2DArray().GetLength(1); x++)
                {
                    if (Program.grid.Get2DArray()[y,x].Equals('M')) {

                    for(int i = 0; i < MonstersArray.GetLength(0); i++) {
                        if ((MonstersArray[i, 2] == 0 && MonstersArray[i, 3] == 0)) {
                            MonstersArray[i, 2] = y;
                            MonstersArray[i, 3] = x;
                            break;
                            }
                        }
                    }
                }
            }
        }
    }
}