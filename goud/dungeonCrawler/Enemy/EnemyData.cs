namespace dungeonCrawler.Enemy
{
    public class EnemyData
    {
        private int health = 100;

        private int _x;
        private int _y;

        public EnemyData(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        
        public int X
        {
            get => this._x;
            set => this._x = value;
        }
        
        public int Y
        {
            get => this._y;
            set => this._y = value;
        }

        public int Health
        {
            get => health;
            set => health = value;
        }
    }
}