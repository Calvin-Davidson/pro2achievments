using System;

namespace dungeonCrawler
{

        public class playerManager
        {
        private int coins = 0;
        private int X = 1;
        private int Y = 3;

        private int HP = 100;
        
        public int playerX
        {
                get { return X; }
                set { X = value; }
        }
        public int playerY
        {
                get { return Y; }
                set { Y = value; }
        }
        public int playercoins
        {
                get { return coins; }
                set { coins = value; }
        }
                public int playerHP
        {
                get { return HP; }
                set { HP = value; }
        }
    }
}
