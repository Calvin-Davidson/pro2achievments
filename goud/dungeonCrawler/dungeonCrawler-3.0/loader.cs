using System;
namespace dungeonCrawler
{
    static class loader
    {
        public static void loadMap(string Map)
       {
            for(int y = 0; y < Program.grid.GetArray().GetLength(0); y++)
            {
                for(int x = 0; x < Program.grid.GetArray().GetLength(1); x++)
                {
                    Console.Write(Program.grid.GetArray()[y,x]);
                    
                }    
                Console.WriteLine();
            }
        }
        public static void loadHP() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your HP " + Program.playerM.playerHP);
            Console.ResetColor();
            loadCoins();    
        }
        public static void loadCoins() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your Coins " + Program.playerM.playercoins);
            Console.ResetColor();
            
        }

    }

}