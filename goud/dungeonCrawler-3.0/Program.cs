using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;

namespace dungeonCrawler
{
    class Program
    {  
        public static playerManager playerM;
        public static gridManager grid;
        public static gameManager gameM;

        public static ArrayList Inventory = new ArrayList();
        private static System.Timers.Timer SPACEtimer;

            static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //Maakt een nieuwe player
            playerM = new playerManager();
            gameM = new gameManager();
            grid = new gridManager();


        	Console.Clear();

            gridMaker.MakeMaps();
            playerManager.setPlayerLocation();
            monsters.LoadMonsterArray();

            Console.Clear();
            
            SetTimer();    

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
            Console.Clear();
            System.Threading.Thread.Sleep(100);
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
                } else {
                    Console.Clear();
                    Console.WriteLine("Key not found");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    loader.loadMap();
                    loader.loadHP();
                    goto WALK;
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
        SPACEtimer = new System.Timers.Timer(100);
        // Hook up the Elapsed event for the timer. 
        SPACEtimer.Elapsed += OnTimedEvent;
        SPACEtimer.AutoReset = true;
        SPACEtimer.Enabled = true;
    }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("PRESS SPACE TO START");
        Console.ResetColor();
        System.Threading.Thread.Sleep(100);
            }
        }
    }