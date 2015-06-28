namespace SuperRPGGameApp.Characters
{
    public class Enemy : Character
    {
        private Position position;
        
        public Enemy(int health, int damage, Position position) 
            : base(health, damage)
        {
            this.Position = position;
        }

        public Position Position { get; set; } //set validation
    }
}
