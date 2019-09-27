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
                    switch(Program.grid.Get2DArray()[y,x]) {
                        case 'P':
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                        case 'M':
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                        case 'H':
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                        case 'K':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                        case 'W':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                        default:
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Gray; 
                        break;
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