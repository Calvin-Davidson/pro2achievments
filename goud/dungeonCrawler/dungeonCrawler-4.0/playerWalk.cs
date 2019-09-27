using System;
namespace dungeonCrawler
{

    class PlayerWalk
    {   
        public static void move(string direction) {
            Char VooruitChar = Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY-1);
            Char AchteruitChar = Program.grid.GetFrom(Program.playerM.playerX, Program.playerM.playerY+1);
            Char RechtsChar = Program.grid.GetFrom(Program.playerM.playerX+1, Program.playerM.playerY);
            Char LinksChar = Program.grid.GetFrom(Program.playerM.playerX-1, Program.playerM.playerY);
            Boolean canwalk = false;
            switch(direction.ToString()) {
                case "Vooruit":
                switch(VooruitChar) {
                    case 'W':
                    //Je wint
                    break;
                    case 'M':
                    //Je komt een monster tegen
                    monsters.fight(Program.playerM.playerX, Program.playerM.playerY-1);
                    break;
                    case 'H':
                    canwalk = true;
                    Program.playerM.playerHP += 75;
                    break;
                    case '$':
                    //Je pakt geld op
                    canwalk = true;
                    Program.playerM.playercoins += 5;
                    break;
                    case 'K':
                    canwalk = true;
                    Program.Inventory.Add("Key");
                    break;
                    case 'D':
                    //Een deur waar je een sleutel nodig hebt
                    if (Program.Inventory.Contains("Key")) {
                    canwalk = true;
                    } else {
                    Console.Beep(40, 100);
                    }
                    break;
                    case '#':
                    //Een muur doet niks
                    canwalk = false;
                    break;
                    default:
                    canwalk = true;
                    break;
                }
               if (canwalk == true) {
                Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY-1, 'P');
                Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
                Program.playerM.playerY--;
                Console.Clear();
                loader.loadMap();
                loader.loadHP();
               }
               break;
                case "Achteruit":
                switch(AchteruitChar) {
                    case 'W':
                    //Je wint
                    break;
                    case 'M':
                    //Je komt een monster tegen
                    monsters.fight(Program.playerM.playerX, Program.playerM.playerY+1);
                    break;
                    case 'H':
                    canwalk = true;
                    Program.playerM.playerHP += 75;
                    break;
                    case '$':
                    //Je pakt geld op
                    canwalk = true;
                    Program.playerM.playercoins += 5;
                    break;
                    case 'K':
                    //Je pakt een key op
                    canwalk = true;
                    Program.Inventory.Add("Key");
                    break;
                    case 'D':
                    //Een deur waar je een sleutel nodig hebt
                    if (Program.Inventory.Contains("Key")) {
                    canwalk = true;
                    } else {
                    Console.Beep(40, 100);
                    }
                    break;
                    case '#':
                    //Een muur doet niks
                    canwalk = false;
                    break;
                    default:
                    canwalk = true;
                    break;
                }
               if (canwalk == true) {
                Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY+1, 'P');
                Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
                Program.playerM.playerY++;
                Console.Clear();
                loader.loadMap();
                loader.loadHP();
               }
               break;
                case "Rechts":
                switch(RechtsChar) {
                    case 'W':
                    //Je wint
                    break;
                    case 'M':
                    //Je komt een monster tegen
                    monsters.fight(Program.playerM.playerX+1, Program.playerM.playerY);
                    break;
                    case 'H':
                    canwalk = true;
                    Program.playerM.playerHP += 75;
                    break;
                    case '$':
                    //Je pakt geld op
                    canwalk = true;
                    Program.playerM.playercoins += 5;
                    break;
                    case 'K':
                    //Je pakt een key op
                    canwalk = true;
                    Program.Inventory.Add("Key");
                    break;
                    case 'D':
                    //Een deur waar je een sleutel nodig hebt
                    if (Program.Inventory.Contains("Key")) {
                    canwalk = true;
                    } else {
                    Console.Beep(40, 100);
                    }
                    break;
                    case '#':
                    //Een muur doet niks
                    canwalk = false;
                    break;
                    default:
                    canwalk = true;
                    break;
                }
               if (canwalk == true) {
                Program.grid.Replace(Program.playerM.playerX+1, Program.playerM.playerY, 'P');
                Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
                Program.playerM.playerX++;
                Console.Clear();
                loader.loadMap();
                loader.loadHP();
               }
               break;
                case "Links":
                    switch(LinksChar) {
                    case 'W':
                    //Je wint
                    break;
                    case 'M':
                    //Je komt een monster tegen
                    monsters.fight(Program.playerM.playerX-1, Program.playerM.playerY);
                    break;
                    case 'H':
                    canwalk = true;
                    Program.playerM.playerHP += 75;
                    break;
                    case '$':
                    //Je pakt geld op
                    canwalk = true;
                    Program.playerM.playercoins += 5;
                    break;
                    case 'K':
                    //Je pakt een key op
                    canwalk = true;
                    Program.Inventory.Add("Key");
                    break;
                    case 'D':
                    //Een deur waar je een sleutel nodig hebt
                    if (Program.Inventory.Contains("Key")) {
                    canwalk = true;
                    } else {
                    Console.Beep(40, 100);
                    }
                    break;
                    case '#':
                    canwalk = false;
                    break;
                    default:
                    canwalk = true;
                    break;
                }
               if (canwalk == true) {
                Program.grid.Replace(Program.playerM.playerX-1, Program.playerM.playerY, 'P');
                Program.grid.Replace(Program.playerM.playerX, Program.playerM.playerY, ' ');
                Program.playerM.playerX--;
                Console.Clear();
                loader.loadMap();
                loader.loadHP();
               }
               break;
            }
        }
    }
}
