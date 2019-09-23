using System;
using System.Timers;

namespace dungeonCrawler
{
    class Program
    {  
        public static playerManager playerM;
        public static gridManager grid;
        public static gameManager gameM;

        private static System.Timers.Timer SPACEtimer;

            static void Main(string[] args)
        {

            SetTimer();

            //Maakt een nieuwe player
            playerM = new playerManager();
            gameM = new gameManager();
            grid = new gridManager();
        	Console.Clear();
            gridmaker.makegrids();
            Console.Clear();

            space:
            SPACEtimer.Start();
            
            Console.SetCursorPosition(0,0);
            var StartKey = Console.ReadKey().Key;
            Console.Clear();
            if (StartKey == ConsoleKey.Escape) {
                SPACEtimer.Stop();
                return;
            } else if (StartKey == ConsoleKey.Spacebar) {
                SPACEtimer.Stop();
                Console.Clear();
                gameM.Started = true;
            }
            if (gameM.Started == false) {
            goto space;
            }
        if (gameM.Started == true) {
        loader.loadMap(gameM.theMap);
            Console.WriteLine("Dungeon Crawler");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your Coins: " + playerM.playercoins);
            Console.ResetColor();
        if (playerM.playerHP <= 0) {
            Console.Clear();
            Console.WriteLine("Game over you are dead");
            return;
        }
    } else {
        return;
    }
        WALK:
        if (gameM.haswon == false) {
            if (playerM.playerHP >= 1) {
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
                } else if (keyPressed == ConsoleKey.Enter) {
                    var read = Console.ReadLine();
                    if (read.ToString() == "exit") {
                        Console.Clear();
                        Console.WriteLine("De game is gestopt");
                        return;
                    }
                }
            if (gameM.Started == true) {
                goto WALK;
            } else {
                return;
               }
            } else {
                Console.Clear();
                Console.WriteLine("You died, game over");
                return;
            }
        } else {
        goto exit;
        }
            exit:
            Console.Clear();
            gameM.Started = false;
            Console.WriteLine("YOU HAVE WON");
            Console.WriteLine("Type exit to leave");
            var entered = Console.ReadLine();
            if (entered.ToString() == "exit") {
                Console.Clear();
                Console.WriteLine("Game exited");
                gameM.Started = false;
                return;
            } else {
                goto exit;
                        }
                    }    
          private static void SetTimer()
   {
        // Create a timer with a two second interval.
        SPACEtimer = new System.Timers.Timer(200);
        // Hook up the Elapsed event for the timer. 
        SPACEtimer.Elapsed += OnTimedEvent;
        SPACEtimer.AutoReset = true;
        SPACEtimer.Enabled = true;
    }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.Clear();
        System.Threading.Thread.Sleep(100);
        Console.WriteLine("PRESS SPACE TO START",e.SignalTime);
            }
        }
    }