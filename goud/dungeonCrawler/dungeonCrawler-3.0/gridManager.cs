using System;

namespace dungeonCrawler
{

        public class gridManager
    {
    private char [,] grid;
            public void add(char [,] grid ){
            this.grid = grid;            
            }
            public char [,] GetArray(){
            return grid;
            }
        public void Replace(int x, int y, char newChar){
            this.grid[y, x] = newChar;
        }
        public char GetFrom(int x, int y){
            return this.grid[x,y];
        }
    }
}
