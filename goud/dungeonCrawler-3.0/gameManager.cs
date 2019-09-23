using System;

namespace dungeonCrawler
{

        public class gameManager
        {
        private Boolean gameStarted;
        private Boolean winned = false;
        private int maptype;
        private string map = "map1";
        public Boolean Started
        {
                get { return gameStarted; }
                set { gameStarted = value; }
                }
                public Boolean haswon
        {
                get { return winned; }
                set { winned = value; }
                }

        public string theMap
        {
                get { return map; }
                set { map = value; }
                }

                        public int theMapType
        {
                get { return maptype; }
                set { maptype = value; }
                }
        }
}