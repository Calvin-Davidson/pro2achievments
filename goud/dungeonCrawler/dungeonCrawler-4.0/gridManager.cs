using System;

namespace dungeonCrawler
{

        public class gridManager
    {
    private char [,] grid;
            public void add(char [,] grid ){
            this.grid = grid;            
            }
            public char [,] Get2DArray(){
            return grid;
            }
        public void Replace(int x, int y, char replaceWith){
            this.grid[y, x] = replaceWith;
        }
        public char GetFrom(int x, int y){
            return this.grid[y, x];
        }
    }
}
