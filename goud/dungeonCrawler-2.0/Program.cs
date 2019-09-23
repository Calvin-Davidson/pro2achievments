using System;

namespace dungeonCrawler
{
    class Program
    {  
        public static playerManager playerM;
        public static gridManager grid;
        public static gameManager gameM;
        public static Array items = new Array[5];

            static void Main(string[] args)
        {
            
            //Maakt een nieuwe player
            playerM = new playerManager();
            gameM = new gameManager();
            grid = new gridManager();

            grid.add(new char [,]
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ','#','#','$',' ',' ',' ','M',' ','$','#',' ','#','#','$',' ',' ',' ',' ',' ','$','#'},
                {'#',' ','$',' ',' ','#','#','#',' ','#','#','#',' ',' ',' ',' ','#','#','#',' ','#','#','#'},
                {'#','P','#','M',' ','#','$',' ',' ',' ',' ','#',' ',' ','#',' ','#','$',' ',' ',' ',' ','#'},
                {'#',' ','#',' ',' ','#',' ',' ',' ','#','$','#',' ',' ','#',' ','#',' ',' ',' ','#','$','#'},
                {'#',' ','#',' ',' ','#','#','#','#','#','#','#',' ',' ','#',' ','#','#','#','#','#','#','#'},
                {'#',' ','#',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ','#',' ','#',' ',' ',' ','#',' ','W'},
                {'#',' ','#',' ',' ','#',' ','#','$','#',' ','#',' ',' ','#',' ','#',' ','#','$','#',' ','#'},
                {'#',' ','#',' ',' ','#',' ','#','#','#',' ','#',' ',' ','#',' ','#',' ','#','#','#','M','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}              
            });
            space:
            Console.Clear();
            if (playerM.playerHP <= 0) {
                Console.WriteLine("You are dead");
                return;
            }
            Console.WriteLine("PRESS SPACE TO START");
                while(Console.ReadKey().Key  == ConsoleKey.Spacebar) {
                Program.Start();
                Program.gameM.Started = true;

                
                while(playerM.playerHP <= 0) {
                    Console.Clear();
                    Console.WriteLine("You are dead");
                    return;
                }

            }
                while(Console.ReadKey().Key == ConsoleKey.Escape) {
                Console.Clear();
                Console.WriteLine("De game is gestopt");
                return;
            }
            goto space;
        }

    public static void Start() {
        gameM.Started = true;
        loader.loadMap();
            Console.WriteLine("Dungeon Crawler");
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("Your Coins: " + playerM.playercoins);
            Console.ResetColor();
        if (playerM.playerHP <= 0) {
            Console.Clear();
            Console.WriteLine("Game over you are dead");
            return;
        }
        WALK:
            var keyPressed = Console.ReadKey().Key;
            if (keyPressed  == ConsoleKey.UpArrow) {
                PlayerWalk.move("Vooruit");
            } else if (keyPressed  == ConsoleKey.DownArrow) {
                PlayerWalk.move("Achteruit");
            } else if (keyPressed  == ConsoleKey.RightArrow) {
                PlayerWalk.move("Rechts");
            } else if (keyPressed  == ConsoleKey.LeftArrow) {
                PlayerWalk.move("Links");
                } else if (keyPressed  == ConsoleKey.Escape) {
                    Console.Clear();
                    Console.WriteLine("De game is gestopt");
                    return;
                }
            if (gameM.Started == true) {
                goto WALK;
            } else {
                return;
            }
        }
    }
}