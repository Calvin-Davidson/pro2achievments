using System;

namespace dungeonCrawler
{

        public class gameManager
        {
        private Boolean gameStarted;
        
        private Boolean won;
        public Boolean Started
        {
                get { return gameStarted; }
                set { gameStarted = value; }
                }
        public Boolean haswon
        {
                get { return won; }
                set { won = value; }
        }
        }
}