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
                {'#',' ','$',' ',' ','#','#','#',' ','#','#','#','M',' ',' ',' ','#','#','#',' ','#','#','#'},
                {'#','P','#','M',' ','#','$',' ',' ',' ',' ','#',' ',' ','#',' ','#','$',' ',' ',' ',' ','#'},
                {'#',' ','#',' ',' ','#',' ',' ',' ','#','$','#',' ',' ','#',' ','#',' ',' ',' ','#','$','#'},
                {'#',' ','#',' ',' ','#','#','#','#','#','#','#',' ',' ','#',' ','#','#','#','#','#','#','#'},
                {'#',' ','#',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ','#','M','#',' ',' ',' ','#',' ','W'},
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
                while(Console.ReadKey(true).Key == ConsoleKey.Spacebar) {
                Program.Start();
                Program.gameM.Started = true;
            }
                while(Console.ReadKey(true).Key == ConsoleKey.Escape) {
                Console.Clear();
                Console.WriteLine("De game is gestopt");
                return;
            }
            goto space;
        }

        // zodat we de gemaakt speler in andere classes kunnen gebruiken
    public static void Start() {
        gameM.Started = true;
        loader.loadMap();
            Console.WriteLine("Dungeon Crawler");
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("Your Coins: " + playerM.playercoins);
            Console.ResetColor();
        controlls:
        if (playerM.playerHP <= 0) {
            Console.Clear();
            Console.WriteLine("Game over you are dead");
            return;
        }
        if (gameM.Started.Equals(true))
            while(Console.ReadKey(true).Key == ConsoleKey.UpArrow) {
                if (playerM.playerHP <= 0) {
                    Console.WriteLine("You are dead");
                    return;
                }
                PlayerWalk.vooruit();
            }
            
            while(Console.ReadKey(true).Key == ConsoleKey.DownArrow && playerM.playerHP >= 1) {
                                if (playerM.playerHP <= 0) {
                    Console.WriteLine("You are dead");
                    return;
                }
                PlayerWalk.achteruit();
            }
            
            while(Console.ReadKey(true).Key == ConsoleKey.RightArrow && playerM.playerHP >= 1) {
                                if (playerM.playerHP <= 0) {
                    Console.WriteLine("You are dead");
                    return;
                }
                PlayerWalk.rechts();
            }
            
            while(Console.ReadKey(true).Key == ConsoleKey.LeftArrow && playerM.playerHP >= 1) {
                                if (playerM.playerHP <= 0) {
                    Console.WriteLine("You are dead");
                    return;
                }
                PlayerWalk.links();
            }
            while(Console.ReadKey(true).Key == ConsoleKey.Escape) {
                Program.Start();
                Program.gameM.Started = true;
            }
            if (playerM.playerHP != 0) {
            goto controlls;
            } else {
                Console.Clear();
                Console.WriteLine("YOU ARE DEAD");
            }
                var input = Console.ReadLine();
                if (input.ToString().Equals("Vooruit")) {
                    PlayerWalk.vooruit();
                } else if (input.ToString().Equals("achteruit")) {
                    PlayerWalk.achteruit();
                } else if (input.ToString().Equals("Rechts")) {
                    PlayerWalk.rechts();
                } else if (input.ToString().Equals("Links")) {
                    PlayerWalk.links();
                } else {
                    Console.WriteLine("ERROR COMMAND NOT FOUND");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    loader.loadMap();
                }
            }
        }    
    }    
