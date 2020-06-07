using System;

namespace dungeonCrawler
{
    public class Player
    {
        public int x = 1;
        public int y = 1;

        private int health = 100;

        public void Undraw()
        {
         Console.SetCursorPosition(x, y);
         Console.Write(' ');
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y);
            Console.Write('P');
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}