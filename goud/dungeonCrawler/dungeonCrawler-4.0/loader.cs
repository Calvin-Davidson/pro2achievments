using System;
namespace dungeonCrawler
{
    static class loader
    {
        public static void loadMap()
       {

            for(int y = 0; y < Program.grid.Get2DArray().GetLength(0); y++)
            {
                for(int x = 0; x < Program.grid.Get2DArray().GetLength(1); x++)
                {
                    if (Program.grid.Get2DArray()[y,x].Equals('P')) {
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Green;
                    } else if (Program.grid.Get2DArray()[y,x].Equals('M')) {
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkRed;
                    } else if (Program.grid.Get2DArray()[y,x].Equals('H')) {
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Red;
                    } else {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(Program.grid.Get2DArray()[y,x]);
                    Console.ResetColor();
                    
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